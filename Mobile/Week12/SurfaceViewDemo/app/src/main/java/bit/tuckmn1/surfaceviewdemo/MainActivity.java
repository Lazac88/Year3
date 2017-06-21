package bit.tuckmn1.surfaceviewdemo;

import android.Manifest;
import android.content.Context;
import android.content.pm.PackageManager;
import android.graphics.Camera;
import android.graphics.PixelFormat;
import android.hardware.camera2.CameraAccessException;
import android.hardware.camera2.CameraCaptureSession;
import android.hardware.camera2.CameraDevice;
import android.hardware.camera2.CameraManager;
import android.hardware.camera2.CaptureRequest;
import android.os.Handler;
import android.os.Message;
import android.support.annotation.IntDef;
import android.support.annotation.NonNull;
import android.support.v4.app.ActivityCompat;
import android.support.v4.content.ContextCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.Surface;
import android.view.SurfaceHolder;
import android.view.SurfaceView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity implements SurfaceHolder.Callback, Handler.Callback
{
    private static final String TAG = "Camera Test";

    static final int MY_PERMISSIONS_REQUEST_CAMERA = 1242;

    private static final int MSG_CAMERA_OPENED = 1;
    private static final int MSG_SURFACE_READY = 2;

    private CameraManager cameraManager;
    private SurfaceView camView;
    private SurfaceHolder surfaceHolder;

    CameraDevice.StateCallback cameraStateCB;
    CameraDevice cameraDevice;
    CameraCaptureSession captureSession;
    private final Handler handler = new Handler(this);

    boolean surfaceCreated = true;
    boolean isCameraConfigured = false;
    private Surface cameraSurface = null;

    String[] cameraIDsList;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {


        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //Set the windows size on a device of unknown size
        getWindow().setFormat(PixelFormat.UNKNOWN);

        camView = (SurfaceView) findViewById(R.id.cameraPreview);

        surfaceHolder = camView.getHolder();

        surfaceHolder.addCallback(this);

        cameraManager = (CameraManager) this.getSystemService(Context.CAMERA_SERVICE);

        //Get and print list of device cameras
        try
        {
            cameraIDsList = this.cameraManager.getCameraIdList();
            for (String id : cameraIDsList)
            {
                Log.v(TAG, "CameraID: " + id);
            }
        }
        catch (CameraAccessException e)
        {
            e.printStackTrace();
        }

        cameraStateCB = new CameraDevice.StateCallback()
        {

            @Override
            public void onOpened(CameraDevice camera)
            {
                Toast.makeText(getApplicationContext(), "onOpened", Toast.LENGTH_SHORT).show();

                cameraDevice = camera;
                handler.sendEmptyMessage(MSG_CAMERA_OPENED);
            }

            @Override
            public void onDisconnected(CameraDevice camera)
            {
                Toast.makeText(getApplicationContext(), "onDisconnected", Toast.LENGTH_SHORT).show();
            }

            @Override
            public void onError(CameraDevice camera, int error)
            {
                Toast.makeText(getApplicationContext(), "onError", Toast.LENGTH_SHORT).show();
            }
        };
    }

    @Override
    protected void onStart()
    {
        super.onStart();

        //requesting permission
        int permissionCheck = ContextCompat.checkSelfPermission(this, Manifest.permission.CAMERA);
        if (permissionCheck != PackageManager.PERMISSION_GRANTED)
        {
            if (ActivityCompat.shouldShowRequestPermissionRationale(this, Manifest.permission.CAMERA))
            {

            }
            else
            {
                ActivityCompat.requestPermissions(this, new String[]{Manifest.permission.CAMERA}, MY_PERMISSIONS_REQUEST_CAMERA);
                Toast.makeText(getApplicationContext(), "request permission", Toast.LENGTH_SHORT).show();
            }
        }
        else
        {
            Toast.makeText(getApplicationContext(), "PERMISSION_ALREADY_GRANTED", Toast.LENGTH_SHORT).show();
            try {
                cameraManager.openCamera(cameraIDsList[1], cameraStateCB, new Handler());
            }
            catch (CameraAccessException e)
            {
                e.printStackTrace();
            }
        }
    }

    @Override
    protected void onStop()
    {
        super.onStop();
        try
        {
            if (captureSession != null)
            {
                captureSession.stopRepeating();
                captureSession.close();
                captureSession = null;
            }

            isCameraConfigured = false;
        }
        catch (final CameraAccessException e)
        {
            // Doesn't matter, closing device anyway
            e.printStackTrace();
        }
        catch (final IllegalStateException e2)
        {
            // Doesn't matter, closing device anyway
            e2.printStackTrace();
        }
        finally
        {
            if (cameraDevice != null) {
                cameraDevice.close();
                cameraDevice = null;
                captureSession = null;
            }
        }
    }

    @Override
    public void surfaceCreated(SurfaceHolder holder)
    {
       cameraSurface = holder.getSurface();
    }

    @Override
    public void surfaceChanged(SurfaceHolder holder, int format, int width, int height)
    {
        cameraSurface = holder.getSurface();
        surfaceCreated = true;
        handler.sendEmptyMessage(MSG_SURFACE_READY);
    }

    @Override
    public void surfaceDestroyed(SurfaceHolder holder)
    {
        surfaceCreated = false;
    }

    @Override
    public boolean handleMessage(Message msg)
    {
        switch (msg.what)
        {
            case MSG_CAMERA_OPENED:
            case MSG_SURFACE_READY:
                // if both surface is created and camera device is opened
                // - ready to set up preview and other things
                if (surfaceCreated && (cameraDevice != null)&& !isCameraConfigured)
                {
                    configureCamera();
                }
                break;
        }

        return true;
    }

    private void configureCamera()
    {
        // prepare list of surfaces to be used in capture requests
        List<Surface> listOfSurfaces = new ArrayList<Surface>();

        listOfSurfaces.add(cameraSurface); // surface for viewfinder preview

        // configure camera with all the surfaces to be ever used
        try
        {
            cameraDevice.createCaptureSession(listOfSurfaces, new CaptureSessionListener(), null);
        }
        catch (CameraAccessException e)
        {
            e.printStackTrace();
        }

        isCameraConfigured = true;
    }

    private class CaptureSessionListener extends CameraCaptureSession.StateCallback
    {
        @Override
        public void onConfigureFailed(final CameraCaptureSession session) {
            Log.d(TAG, "CaptureSessionConfigure failed");
        }

        @Override
        public void onConfigured(final CameraCaptureSession session) {
            Log.d(TAG, "CaptureSessionConfigure onConfigured");
            captureSession = session;

            try
            {
                CaptureRequest.Builder previewRequestBuilder = cameraDevice.createCaptureRequest(CameraDevice.TEMPLATE_PREVIEW);
                previewRequestBuilder.addTarget(cameraSurface);
                captureSession.setRepeatingRequest(previewRequestBuilder.build(), null, null);
            }
            catch (CameraAccessException e)
            {
                Log.d(TAG, "setting up preview failed");
                e.printStackTrace();
            }
        }
    }

    @Override
    public void onRequestPermissionsResult(int requestCode, @NonNull String[] permissions, @NonNull int[] grantResults)
    {
        super.onRequestPermissionsResult(requestCode, permissions, grantResults);

        switch (requestCode)
        {
            case MY_PERMISSIONS_REQUEST_CAMERA:
                if (ActivityCompat.checkSelfPermission(this, Manifest.permission.CAMERA) == PackageManager.PERMISSION_GRANTED)
                    try
                    {
                        cameraManager.openCamera(cameraIDsList[1], cameraStateCB, new Handler());
                    }
                    catch (CameraAccessException e)
                    {
                        e.printStackTrace();
                    }
                break;
        }
    }
}
