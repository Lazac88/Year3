package bit.tuckmn1.attractionfinder;


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

            //Create marker options to change the colour of your location to blue
            MarkerOptions markerOptions = new MarkerOptions().position(currentLocation).title("You Are Here").icon(BitmapDescriptorFactory.defaultMarker(BitmapDescriptorFactory.HUE_AZURE));
            mMap.addMarker(markerOptions);
            mMap.moveCamera(CameraUpdateFactory.newLatLng(currentLocation));
            mMap.animateCamera(CameraUpdateFactory.newLatLngZoom(currentLocation, 13.0f));

            //Create a marker for each place in the list
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

    //Inner class to direct the user to the details page when they click the info window
    public class onInfoWindowClickHandler implements GoogleMap.OnInfoWindowClickListener
    {
        @Override
        public void onInfoWindowClick(Marker marker)
        {
            String id = marker.getId();
            //Get the number only by trimming the first character
            String formattedString = id.substring(1);

            //Have to minus 1 as the list is zero based and marker id are one in front
            //This is due to personal marker being the first
            int positionId = (Integer.parseInt(formattedString) - 1);
            activity.setSelectedListItem(positionId);
            Place p = placeData.get(positionId);
            activity.LaunchDetailsFragment(p);
        }
    }

    //No Required but could be use with future functionality
    public class onMarkerClickedHandler implements GoogleMap.OnMarkerClickListener
    {
        @Override
        public boolean onMarkerClick(Marker marker)
        {
            return false;
        }
    }
}
