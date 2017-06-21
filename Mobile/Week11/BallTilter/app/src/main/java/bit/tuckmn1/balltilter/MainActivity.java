package bit.tuckmn1.balltilter;

import android.content.Context;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.TextView;

import java.text.DecimalFormat;
import java.util.Timer;
import java.util.TimerTask;

public class MainActivity extends AppCompatActivity
{
    private SensorManager sensorManager;
    private Sensor accSensor;

    private Timer timer;

    private ImageView ball;
    private TextView tvResult;

    private float xSpeed;
    private float ySpeed;

    int count;

    private onSensorAccelEvent accelEvent;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        accelEvent = new onSensorAccelEvent();

        xSpeed = 0;
        ySpeed = 0;

        count = 0;

        sensorManager = (SensorManager) getSystemService(Context.SENSOR_SERVICE);
        accSensor = sensorManager.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);

        ball = (ImageView) findViewById(R.id.ball);
        tvResult = (TextView) findViewById(R.id.tvResult);
    }

    @Override
    protected void onResume()
    {
        super.onResume();
        sensorManager.registerListener(accelEvent, accSensor, 30000);
    }

    @Override
    protected void onStop()
    {
        super.onStop();
        sensorManager.unregisterListener(accelEvent);
    }

    public class onSensorAccelEvent implements SensorEventListener
    {
        @Override
        public void onSensorChanged(SensorEvent event)
        {

            xSpeed = event.values[0];
            ySpeed = event.values[1];
            setAccel(xSpeed, ySpeed);

            moveBall(event.values[0], event.values[1]);
        }

        @Override
        public void onAccuracyChanged(Sensor sensor, int accuracy) {

        }
    }


    public void moveBall(float xSpeed, float ySpeed)
    {
        float xAxis = ball.getX() - xSpeed;
        float yAxis = ball.getY() + ySpeed;

        int xPos = Math.round(xAxis);
        int yPos = Math.round(yAxis);

        ball.setX(xPos);
        ball.setY(yPos);
    }

    public void setAccel(float x, float y)
    {
        DecimalFormat dc = new DecimalFormat("#.###");
        tvResult.setText("X: " + dc.format(x) + " Y: " + dc.format(y));
    }
}
