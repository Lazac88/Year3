package bit.tuckmn1.camerademo;

import android.Manifest;
import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.hardware.camera2.CameraAccessException;
import android.hardware.camera2.CameraCaptureSession;
import android.hardware.camera2.CameraCharacteristics;
import android.hardware.camera2.CameraDevice;
import android.hardware.camera2.CameraManager;
import android.hardware.camera2.CaptureRequest;
import android.media.Image;
import android.media.ImageReader;
import android.net.Uri;
import android.os.Environment;
import android.os.HandlerThread;
import android.provider.MediaStore;
import android.support.annotation.NonNull;
import android.support.v4.app.ActivityCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.util.Size;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.Toast;

import java.io.File;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.logging.Handler;

public class MainActivity extends AppCompatActivity
{
    private static final int IMG_CAPTURE = 1;
    private final static int CAM_REQUEST_CODE = 1;

    private File photoFile;
    private Uri photoFileUri;

    private Button btnTakePicture;
    private ImageView iv1, iv2, iv3, iv4;

    //=========================================CAMERA 2 VARIABLES========================================//
    private CameraManager cameraManager;
    private CameraCharacteristics cameraCharacteristics;
    private String[] cameraListIds;
    int cameraPermissionOK;

    private String cameraID;
    private CameraDevice cameraDevice;
    private CameraCaptureSession cameraCaptureSession;
    private CaptureRequest captureRequest;
    private CaptureRequest.Builder captureRequestBuilder;
    private Size imageDimention;
    private ImageReader imageReader;
    private File file;

    private final static int REQUEST_CAMERA_PERMISSION = 200;
    private boolean flashSupported;
    private Handler backgroundHandler;
    private HandlerThread backgroundThread;


    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //Camera Manager
        cameraManager = (CameraManager) getSystemService(Context.CAMERA_SERVICE);
        cameraPermissionOK = -100;
        try
        {
            cameraListIds = cameraManager.getCameraIdList();
            cameraCharacteristics = cameraManager.getCameraCharacteristics(cameraListIds[0]);
        }
        catch (CameraAccessException e)
        {
            Log.i("Tag", "Getting CameraIds Failed");
            e.printStackTrace();
        }


        //Get components from view
        btnTakePicture = (Button) findViewById(R.id.btnTakePicture);
        iv1 = (ImageView) findViewById(R.id.iv1);
        iv2 = (ImageView) findViewById(R.id.iv2);
        iv3 = (ImageView) findViewById(R.id.iv3);
        iv4 = (ImageView) findViewById(R.id.iv4);

        btnTakePicture.setOnClickListener(new onButtonClickEventHandler());
        boolean cameraPermissionsOK = checkCameraPermission();
        {
            if(!cameraPermissionsOK)
            {
                requestCameraPermission();
            }
        }
    }

    public boolean checkCameraPermission()
    {
        cameraPermissionOK = ActivityCompat.checkSelfPermission(this, Manifest.permission.CAMERA);
        if(cameraPermissionOK != PackageManager.PERMISSION_GRANTED)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void requestCameraPermission()
    {
        String[] permissionsIWant = new String[] { Manifest.permission.CAMERA};
        ActivityCompat.requestPermissions(this, permissionsIWant, CAM_REQUEST_CODE);
    }

    @Override
    public void onRequestPermissionsResult(int requestCode, @NonNull String[] permissions, @NonNull int[] grantResults)
    {
        if(grantResults.length != 0)
        {
            if(grantResults[0] == PackageManager.PERMISSION_GRANTED)
            {
                //Best to check twice
                checkCameraPermission();
            }
        }
    }

    public class onButtonClickEventHandler implements View.OnClickListener
    {
        @Override
        public void onClick(View v)
        {
            boolean cameraPermissionsOK = checkCameraPermission();
            if(cameraPermissionsOK)
            {
                //Get time stamped file
                photoFile = GetPhotoFile();

                //Generate Uri from the file instance
                photoFileUri = Uri.fromFile(photoFile);

                //Create an intent for the image capture content provider
                Intent imageCaptureIntent = new Intent(MediaStore.ACTION_IMAGE_CAPTURE);

                //Attach your Uri to the intent
                imageCaptureIntent.putExtra(MediaStore.EXTRA_OUTPUT, photoFileUri);

                //Launch the intent, waiting on the result
                //When the user is finished with the camera, onActivityResult() is raised.
                startActivityForResult(imageCaptureIntent, IMG_CAPTURE);
            }
            else
            {
                requestCameraPermission();
            }
        }
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data)
    {
        //Is this the return we are waiting for?
        if(requestCode == IMG_CAPTURE)
        {
            //Did we get data?
            if(resultCode == RESULT_OK) //This is a const for -1
            {
                //We need the file path for BitmapFactory, not the file
                String realFilePath = photoFile.getPath();  //Safe way to do this...

                Bitmap userPhotoBitmap = BitmapFactory.decodeFile(realFilePath);

                iv1.setImageBitmap(userPhotoBitmap);
                iv2.setImageBitmap(userPhotoBitmap);
                iv3.setImageBitmap(userPhotoBitmap);
                iv4.setImageBitmap(userPhotoBitmap);
            }
            else
            {
                Toast.makeText(this, "No photo was saved. Somehting went wrong", Toast.LENGTH_LONG).show();
            }
        }
    }

    public File GetPhotoFile()
    {
        //Fetch system image folder
        File imageRootPath = Environment.getExternalStoragePublicDirectory(Environment.DIRECTORY_PICTURES);

        //Make subdirectory if it doesn't exist
        File imageStorageDirectory = new File(imageRootPath, "CameraDemoApp");
        if(!imageStorageDirectory.exists())
        {
            imageStorageDirectory.mkdirs();
        }

        //Get Timestamp
        SimpleDateFormat timeStampFormat = new SimpleDateFormat("yyyyMMdd_HHmmss");
        Date currentTime = new Date();
        String timeStamp = timeStampFormat.format(currentTime);

        //Make file name
        String photoFileName = "IMG_" + timeStamp + ".jpg";

        //Make ile object from directory and fileName
        File photoFile = new File(imageStorageDirectory.getPath() + File.separator + photoFileName);
        return photoFile;
    }


}
