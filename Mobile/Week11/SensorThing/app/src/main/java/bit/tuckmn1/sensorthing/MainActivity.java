package bit.tuckmn1.sensorthing;

import android.content.Context;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import java.text.DecimalFormat;
import java.util.List;

public class MainActivity extends AppCompatActivity
{

    private SensorManager sensorManager;
    private List<Sensor> deviceSensors;

    private TextView tvResult;
    private Button sensors, light, xyz;

    private ProgramState state;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        sensorManager = (SensorManager) getSystemService(Context.SENSOR_SERVICE);
        deviceSensors = sensorManager.getSensorList(Sensor.TYPE_ALL);
        Sensor proxSensor = sensorManager.getDefaultSensor(Sensor.TYPE_PROXIMITY);
        Sensor accSensor = sensorManager.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);

        sensorManager.registerListener(new onSensorDistanceEvent(), proxSensor, SensorManager.SENSOR_DELAY_NORMAL);
        sensorManager.registerListener(new onSensorAccelEvent(), accSensor, 50000000);

        sensors = (Button) findViewById(R.id.btnListSensors);
        light = (Button) findViewById(R.id.btnLight);
        xyz = (Button) findViewById(R.id.btnXYZ);

        tvResult = (TextView) findViewById(R.id.tvResult);

        sensors.setOnClickListener(new onClickSensors());
        light.setOnClickListener(new onDistanceClick());
        xyz.setOnClickListener(new onXYZClick());

        this.state = ProgramState.NONE;
    }

    public class onClickSensors implements View.OnClickListener
    {
        @Override
        public void onClick(View v)
        {

            state = ProgramState.LIST;
            String result = "";

            for(Sensor sen : deviceSensors)
            {
                result += sen.getName() + "\n";
            }
            tvResult.setText(result);
        }
    }

    public class onDistanceClick implements  View.OnClickListener
    {
        @Override
        public void onClick(View v)
        {
            state = ProgramState.DISTANCE;
        }
    }

    public class onXYZClick implements  View.OnClickListener
    {
        @Override
        public void onClick(View v)
        {
            state = ProgramState.ACCEL;
        }
    }

    public void setDistance(float distance)
    {
        String result = distance <= 5 ? "near" : "far";
        tvResult.setText(result);
    }

    public void setAccel(float x, float y, float z)
    {
        DecimalFormat dc = new DecimalFormat("#.###");
        tvResult.setText("X: " + dc.format(x) + " Y: " + dc.format(y) + " Z: " +  dc.format(z));
    }

    public class onSensorDistanceEvent implements SensorEventListener
    {
        @Override
        public void onSensorChanged(SensorEvent event)
        {
            if(event.sensor.getType() == Sensor.TYPE_PROXIMITY)
            {
                if(state == ProgramState.DISTANCE)
                {
                    setDistance(event.values[0]);
                }
            }
        }
        @Override
        public void onAccuracyChanged(Sensor sensor, int accuracy)
        {

        }
    }

    public class onSensorAccelEvent implements SensorEventListener
    {
        @Override
        public void onSensorChanged(SensorEvent event)
        {
            if(event.sensor.getType() == Sensor.TYPE_ACCELEROMETER)
            {
                if(state == ProgramState.ACCEL)
                {
                    setAccel(event.values[0], event.values[1], event.values[2]);
                }
            }
        }

        @Override
        public void onAccuracyChanged(Sensor sensor, int accuracy) {

        }
    }

    private static enum ProgramState
    {
        NONE,
        LIST,
        DISTANCE,
        ACCEL;
    }
}
