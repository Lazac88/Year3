package bit.tuckmn1.barcodereaderinclass;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.util.SparseArray;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

import com.google.android.gms.vision.CameraSource;
import com.google.android.gms.vision.Detector;
import com.google.android.gms.vision.barcode.Barcode;
import com.google.android.gms.vision.barcode.BarcodeDetector;

import java.io.IOException;

public class QrReader extends AppCompatActivity
{

    public static final int QR_RETURN_CODE = 1;
    BarcodeDetector barcodeDetector;
    BarcodeDetector.Builder detectorBuilder;

    CameraSource cameraSource;

    SurfaceView surfaceView;
    SurfaceHolder cameraSurfaceHolder;


    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_qr_reader);

        detectorBuilder = new BarcodeDetector.Builder(this);
        detectorBuilder.setBarcodeFormats(Barcode.QR_CODE);
        barcodeDetector = detectorBuilder.build();

        //Bind our BarcodeDetectorProcessor to our barcode detector
        barcodeDetector.setProcessor(new BarcodeDetectorProcessor());

        cameraSource = new CameraSource.Builder(this, barcodeDetector).setRequestedPreviewSize(640, 480).build();

        surfaceView = (SurfaceView) findViewById(R.id.surfaceView);
        cameraSurfaceHolder = surfaceView.getHolder();
        cameraSurfaceHolder.addCallback(new SurfaceHolderSetUp());


    }

    public class SurfaceHolderSetUp implements SurfaceHolder.Callback
    {
        @Override
        public void surfaceCreated(SurfaceHolder holder)
        {
            try
            {
                cameraSource.start(surfaceView.getHolder());
            }
            catch(IOException ie)
            {
                Log.e("Camera Source", ie.getMessage());
            }
        }

        @Override
        public void surfaceChanged(SurfaceHolder holder, int format, int width, int height)
        {}

        @Override
        public void surfaceDestroyed(SurfaceHolder holder)
        {
            cameraSource.stop();
        }
    }//end SurfaceCallBack

    public class BarcodeDetectorProcessor implements Detector.Processor<Barcode>
    {
        @Override
        public void release()
        { }

        @Override
        public void receiveDetections(Detector.Detections<Barcode> detections)
        {
            //Detector.getDetectedItems returns a SparseArray of all the things it has been sent from the camera
            //SparseArray is just a different underlying data structure for arrays, which is more efficient for fetching
            SparseArray<Barcode> barcodes = detections.getDetectedItems();

            //Check that something was detected, just in case
            if(barcodes.size() != 0)
            {
                //Grab the QR text out of the "detected thing"
                String qrCodeMessage = barcodes.valueAt(0).displayValue;

                //Intent intent = new Intent(QrReader.this, MainActivity.class);
                Intent intent = new Intent();
                intent.putExtra("month", qrCodeMessage);

                //onActivityResult(QR_RETURN_CODE, RESULT_OK, intent);
                setResult(RESULT_OK, intent);
                finish();
            }
        }
    }
}
