package bit.tuckmn1.googlemapsjumper;

import android.support.v4.app.FragmentActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.OnMapReadyCallback;
import com.google.android.gms.maps.SupportMapFragment;
import com.google.android.gms.maps.UiSettings;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.MarkerOptions;

import java.text.DecimalFormat;
import java.util.Random;

public class MapsActivity extends FragmentActivity implements OnMapReadyCallback {

    private GoogleMap mMap;
    private UiSettings uiSettings;

    private Random rand;

    private Button btnJumpButton;

    //Lat and long constants
    private final int LATITUDE = 90;
    private final int LONGITUDE = 180;

    private double lat;
    private double lng;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_maps);
        // Obtain the SupportMapFragment and get notified when the map is ready to be used.
        SupportMapFragment mapFragment = (SupportMapFragment) getSupportFragmentManager()
                .findFragmentById(R.id.map);
        mapFragment.getMapAsync(this);

        //Get button
        btnJumpButton = (Button) findViewById(R.id.btnJumpLocation);
        btnJumpButton.setOnClickListener(new OnJumpButtonClickHandler());

        rand = new Random();
        lat = 0;
        lng = 0;
    }

    private class OnJumpButtonClickHandler implements View.OnClickListener
    {
        @Override
        public void onClick(View v)
        {
            lat = getRandomNumber(LATITUDE);
            lng = getRandomNumber(LONGITUDE);
            LatLng randomCoords = new LatLng(lat, lng);
            mMap.clear();

            mMap.addMarker(new MarkerOptions().position(randomCoords));
            mMap.moveCamera(CameraUpdateFactory.newLatLng(randomCoords));
        }
    }


    /**
     * Manipulates the map once available.
     * This callback is triggered when the map is ready to be used.
     * This is where we can add markers or lines, add listeners or move the camera. In this case,
     * we just add a marker near Sydney, Australia.
     * If Google Play services is not installed on the device, the user will be prompted to install
     * it inside the SupportMapFragment. This method will only be triggered once the user has
     * installed Google Play services and returned to the app.
     */
    @Override
    public void onMapReady(GoogleMap googleMap) {
        mMap = googleMap;
        uiSettings = mMap.getUiSettings();
        uiSettings.setZoomControlsEnabled(true);
        // Add a marker in Sydney and move the camera
        LatLng sydney = new LatLng(-34, 151);
        mMap.addMarker(new MarkerOptions().position(sydney).title("Marker in Sydney"));
        mMap.moveCamera(CameraUpdateFactory.newLatLng(sydney));
    }

    //Method to randomly generate a latitude or longitude
    public double getRandomNumber(int endRange)
    {
        double d = rand.nextDouble();
        d *= endRange;
        d = roundLatAndLong(d);
        d = randChangeToNegative(d);
        return d;
    }

    // 50/50 chance of swapping the input to a negative number
    public double randChangeToNegative(double d)
    {
        double number = d;
        int negChance = rand.nextInt(2);
        if(negChance == 0)
        {
            number *= -1;
        }
        return number;
    }

    //Rounds latitude and longitude to 11 decimal places
    public double roundLatAndLong(double d)
    {
        DecimalFormat elevenDForm = new DecimalFormat("#.###########");
        return Double.valueOf(elevenDForm.format(d));
    }
}
