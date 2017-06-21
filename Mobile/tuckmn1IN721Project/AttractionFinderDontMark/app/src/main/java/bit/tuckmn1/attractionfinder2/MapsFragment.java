package bit.tuckmn1.attractionfinder2;


import android.os.Bundle;
import android.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.MapFragment;
import com.google.android.gms.maps.OnMapReadyCallback;
import com.google.android.gms.maps.UiSettings;
import com.google.android.gms.maps.model.BitmapDescriptorFactory;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.Marker;
import com.google.android.gms.maps.model.MarkerOptions;

import java.util.List;


/**
 * A simple {@link Fragment} subclass.
 */
public class MapsFragment extends Fragment
{
    private MapFragment mapFragment;
    private GoogleMap mMap;
    private UiSettings uiSettings;

    private MainActivity activity;

    private LatLng currentLocation;

    List<Place> placeData;

    public MapsFragment()
    {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState)
    {
        // Inflate the layout for this fragment
        View v = inflater.inflate(R.layout.activity_maps, container, false);

        mapFragment = ((MapFragment) getChildFragmentManager().findFragmentById(R.id.map2));

        activity = (MainActivity) getActivity();
        currentLocation = activity.getCurrentLocation();
        placeData = activity.getMyData();

        mapFragment.getMapAsync(new onMapReadyHandler());
        return v;
    }

    public class onMapReadyHandler implements OnMapReadyCallback
    {
        @Override
        public void onMapReady(GoogleMap googleMap)
        {
            mMap = googleMap;
            //mMap.setOnMarkerClickListener(new onMarkerClickedHandler());
            mMap.setOnInfoWindowClickListener(new onInfoWindowClickHandler());

            //Custom map controls
            uiSettings = mMap.getUiSettings();
            uiSettings.setZoomControlsEnabled(true);
            // Add a marker in Sydney and move the camera
            //LatLng sydney = new LatLng(-34, 151);
            MarkerOptions markerOptions = new MarkerOptions().position(currentLocation).title("You Are Here").icon(BitmapDescriptorFactory.defaultMarker(BitmapDescriptorFactory.HUE_AZURE));
            mMap.addMarker(markerOptions);
            mMap.moveCamera(CameraUpdateFactory.newLatLng(currentLocation));
            mMap.animateCamera(CameraUpdateFactory.newLatLngZoom(currentLocation, 13.0f));

            for(Place p : placeData)
            {
                double pLat = p.getLatitude();
                double pLng = p.getLongitude();
                LatLng placeMarker = new LatLng(pLat, pLng);
                String pName = p.getName();
                mMap.addMarker(new MarkerOptions().position(placeMarker).title(pName));
            }
        }
    }

    public class onInfoWindowClickHandler implements GoogleMap.OnInfoWindowClickListener
    {
        @Override
        public void onInfoWindowClick(Marker marker)
        {
            String id = marker.getId();
            String formattedString = id.substring(1);
            int positionId = (Integer.parseInt(formattedString) - 1);
            activity.setSelectedListItem(positionId);
            Place p = placeData.get(positionId);
            activity.LaunchDetailsFragment(p);
        }
    }

    public class onMarkerClickedHandler implements GoogleMap.OnMarkerClickListener
    {
        @Override
        public boolean onMarkerClick(Marker marker)
        {

            return false;
        }
    }
}
