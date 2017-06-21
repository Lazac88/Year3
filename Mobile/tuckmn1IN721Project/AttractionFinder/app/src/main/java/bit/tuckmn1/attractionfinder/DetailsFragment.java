package bit.tuckmn1.attractionfinder;


import android.os.Bundle;
import android.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.MapFragment;
import com.google.android.gms.maps.OnMapReadyCallback;
import com.google.android.gms.maps.UiSettings;
import com.google.android.gms.maps.model.BitmapDescriptorFactory;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.MarkerOptions;


/**
 * A simple {@link Fragment} subclass.
 */
public class DetailsFragment extends Fragment
{
    Place selectedPlace;

    TextView tvTitle;
    TextView tvAddress;

    ImageView ivPlaceImage;

    //Required for maps
    private MapFragment mapFragment;
    private GoogleMap mMap;
    private UiSettings uiSettings;
    private LatLng currentLocation;

    public DetailsFragment()
    {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState)
    {
        // Inflate the layout for this fragment
        View v = inflater.inflate(R.layout.fragment_details, container, false);
        selectedPlace = getArguments().getParcelable("place");

        tvTitle = (TextView) v.findViewById(R.id.tvTitle);
        tvAddress = (TextView) v.findViewById(R.id.tvAddress);
        ivPlaceImage = (ImageView) v.findViewById(R.id.ivPlaceImage);

        tvTitle.setText(selectedPlace.Name);
        tvAddress.setText(selectedPlace.Address);
        ivPlaceImage.setImageBitmap(selectedPlace.PlaceImage);

        mapFragment = ((MapFragment) getChildFragmentManager().findFragmentById(R.id.detailsMap));
        MainActivity activity = (MainActivity) getActivity();
        currentLocation = activity.getCurrentLocation();

        mapFragment.getMapAsync(new onMapReadyHandler());

        return v;
    }

    public class onMapReadyHandler implements OnMapReadyCallback
    {
        @Override
        public void onMapReady(GoogleMap googleMap)
        {
            mMap = googleMap;

            //Custom map controls
            uiSettings = mMap.getUiSettings();
            uiSettings.setZoomControlsEnabled(true);

            //Create marker option to change the users location marker to blue
            MarkerOptions markerOptions = new MarkerOptions().position(currentLocation).title("You Are Here").icon(BitmapDescriptorFactory.defaultMarker(BitmapDescriptorFactory.HUE_AZURE));
            mMap.addMarker(markerOptions);
            mMap.moveCamera(CameraUpdateFactory.newLatLng(currentLocation));

            //Get the location info from the place being lookd at
            double pLat = selectedPlace.getLatitude();
            double pLng = selectedPlace.getLongitude();
            LatLng placeMarker = new LatLng(pLat, pLng);
            String pName = selectedPlace.getName();
            mMap.addMarker(new MarkerOptions().position(placeMarker).title(pName));

            //Animate the camera to focus on the place
            mMap.animateCamera(CameraUpdateFactory.newLatLngZoom(placeMarker, 13.0f));
        }
    }


    //If I could find a API that provides business details I would create an AsyncTask here to get the business details
}
