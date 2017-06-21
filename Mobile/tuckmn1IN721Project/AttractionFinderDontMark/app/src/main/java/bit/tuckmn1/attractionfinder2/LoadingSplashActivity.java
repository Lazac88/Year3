package bit.tuckmn1.attractionfinder2;

import android.app.ProgressDialog;
import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.location.Criteria;
import android.location.Location;
import android.location.LocationListener;
import android.location.LocationManager;
import android.os.AsyncTask;
import android.os.Bundle;
import android.os.Parcelable;
import android.support.v4.app.ActivityCompat;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;

import com.google.android.gms.maps.model.LatLng;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.ArrayList;
import java.util.List;

public class LoadingSplashActivity extends AppCompatActivity
{
    private static final String ZERO_RESULTS = "ZERO_RESULTS";

    //Instance of progress dialog
    ProgressDialog progress;

    //Location variables
    static final int LOCATION_REQ_CODE = 42;
    String sLat;
    String sLng;

    double latitude;
    double longitude;

    //=================================================GPS Variables===============================================//
    //Get a LocationManager
    LocationManager locationManager;
    //Get default Criteria
    Criteria defaultCriteria;
    //Get the provider name
    String providerName;
    //Current Location
    Location myLocation;
    int fineLocationOk;
    int coarseLocationOk;
    //=============================================================================================================//


    //Class to help with JSON unpacking
    private JSONProcessor jPro;

    //Object to hold all data gathered from API
    private PlaceDbSet placeDbSet;

    //Lists to hold the different place types
    private ArrayList<String> attractionList;
    private ArrayList<String> diningList;
    private ArrayList<String> accomodationList;

    private PlacesApiStub placesApiStub;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.content_loading_splash);

        jPro = new JSONProcessor();
        placeDbSet = new PlaceDbSet();

        //Fill place lists
        attractionList = FillAttractionList();
        diningList = FillDiningList();
        accomodationList = FillAccommodationList();

        //=================================================GPS Variables===============================================//

        locationManager = (LocationManager) getSystemService(Context.LOCATION_SERVICE);

        defaultCriteria = new Criteria();
        sLat = "";
        sLng = "";

        //Check permission. Get location
        boolean locationPermissionsOk = checkLocationPermission();
        if(locationPermissionsOk)
        {
            //Get current location and start API call to get nearby places
            providerName = locationManager.getBestProvider(new Criteria(), false);
            while(providerName == null){ providerName = locationManager.getBestProvider(new Criteria(), false);}
            locationManager.requestLocationUpdates(providerName, 100, 1, new CustomLocationListener());
            GetLocationStartAPI();
        }
        else
        {
            requestLocationPermission();
        }

        //=============================================================================================================//

        placesApiStub = new PlacesApiStub();


    }//end onCreate

    //===============================LOCATION FINDING & PERMISSION METHODS===============================//
    //Checks coarse and fine location permissions
    public boolean checkLocationPermission()
    {
        fineLocationOk = ActivityCompat.checkSelfPermission(this, android.Manifest.permission.ACCESS_FINE_LOCATION);
        coarseLocationOk = ActivityCompat.checkSelfPermission(this, android.Manifest.permission.ACCESS_COARSE_LOCATION);

        if((fineLocationOk != PackageManager.PERMISSION_GRANTED) || (coarseLocationOk != PackageManager.PERMISSION_GRANTED))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    //Method to raise an async permission dialogue box
    public void requestLocationPermission()
    {
        String[] permissionsIWant = new String[] { android.Manifest.permission.ACCESS_FINE_LOCATION, android.Manifest.permission.ACCESS_COARSE_LOCATION};

        //Final method parameter can be any number. Used to track what Async task is being used
        ActivityCompat.requestPermissions(this, permissionsIWant, LOCATION_REQ_CODE);
    }

    @Override
    public void onRequestPermissionsResult(int requestCode, String[] permissions, int[] grantResults)
    {
        if(grantResults.length != 0)
        {
            if(grantResults[0] == PackageManager.PERMISSION_GRANTED)    //Positive Result
            {
                //Get current location and start API call to get places
                GetLocationStartAPI();
            }
            else
            {
                //Permission Denied
                requestLocationPermission();
            }
        }
        else
        {
            //User pressed back button during permissions
        }
    }

    public class CustomLocationListener implements LocationListener
    {
        @Override
        public void onLocationChanged(Location location) {
            myLocation = location;
        }

        @Override
        public void onStatusChanged(String provider, int status, Bundle extras) {

        }

        @Override
        public void onProviderEnabled(String provider) {

        }

        @Override
        public void onProviderDisabled(String provider) {

        }
    }

    public void GetLocationStartAPI()
    {
        //Approved style is to check twice
        checkLocationPermission();


        //locationManager.requestSingleUpdate(LocationManager.GPS_PROVIDER, new CustomLocationListener(), null);
        while(providerName == null){ providerName = locationManager.getBestProvider(new Criteria(), false);}
        myLocation = locationManager.getLastKnownLocation(providerName);
        latitude = myLocation.getLatitude();
        longitude = myLocation.getLongitude();
        //locationManager.requestLocationUpdates(providerName, 1000, 100, new CustomLocationListener());

        //Fake lat long
        //latitude = -45.8787605;
        //longitude = 170.5027976;

        LatLng latLng = new LatLng(latitude, longitude);

        //Call API to get data for places DB
        AsyncAPIShowRawJSON asyncAPIShowRawJSON = new AsyncAPIShowRawJSON();
        asyncAPIShowRawJSON.execute(latLng);
    }


    //================================Find Places API Call========================================//

    class AsyncAPIShowRawJSON extends AsyncTask<LatLng, Void, PlacesListStringResults>
    {
        private String getJSONFromURL(String url)
        {
            String JSONString = null;
            try
            {
                //Convert URL string to URLObject
                URL URLObject = new URL(url);

                //Create HttpURLConnection object via openConnection command
                HttpURLConnection connection = (HttpURLConnection) URLObject.openConnection();

                //Send the URL
                connection.connect();

                //Grab response code and check if response is successful
                int resCode = connection.getResponseCode();
                if(resCode == 200)
                {
                    InputStream is = connection.getInputStream();
                    InputStreamReader isr = new InputStreamReader(is);
                    BufferedReader br = new BufferedReader(isr);
                    //Read the input
                    String responseString;
                    StringBuilder stringBuilder = new StringBuilder();
                    while((responseString = br.readLine()) != null)
                    {
                        stringBuilder = stringBuilder.append(responseString);
                    }
                    //Get the string from the stringBuilder
                    JSONString = stringBuilder.toString();
                }
            }
            catch(Exception e)
            {
                e.printStackTrace();
            }

            return JSONString;
        }

        public String GetURL(String type, String lat, String lng)
        {
            //Example URL
            //https://maps.googleapis.com/maps/api/place/textsearch/json?location=-45.8787605,170.5027976&radius=4000&type=all&key=AIzaSyBOm2SY3mY9Awm8qmxoIMWT236M3bGZB8k
            //https://maps.googleapis.com/maps/api/place/textsearch/json?location=-45.8787605,170.5027976&radius=1000&type=attraction&key=AIzaSyBOm2SY3mY9Awm8qmxoIMWT236M3bGZB8k

            //Temporary Hand Coded Lat and Lng
            String fLat = "-45.8787605";
            String fLng = "170.5027976";

            //Create url
            String url = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=" + lat + "," + lng;

            url += "&radius=4000&key=AIzaSyBOm2SY3mY9Awm8qmxoIMWT236M3bGZB8k&type=" + type;
            return url;
        }

        @Override
        protected PlacesListStringResults doInBackground(LatLng... params)
        {
            //Start progress spinner
            publishProgress();

            LatLng latLng = params[0];
            sLat = Double.toString(latLng.latitude);
            sLng = Double.toString(latLng.longitude);

            //Declare a PlacesListStringResults to hold data passed to onPostExecute
            PlacesListStringResults apiResults = new PlacesListStringResults();
            List<String> attractionResults = new ArrayList<String>();
            String JSONString = null;

            //Get all attraction JSON strings
            for(String s : attractionList)
            {
                String url = GetURL(s, sLat, sLng);
                JSONString = getJSONFromURL(url);
                apiResults.addAttractionJsonString(JSONString);
            }
            //JSONString = placesApiStub.GetJSONString();
            //apiResults.addAttractionJsonString(JSONString);

            //Get all accommodation JSON strings
            for(String s : accomodationList)
            {
                String url = GetURL(s, sLat, sLng);
                JSONString = getJSONFromURL(url);
                apiResults.addAccommodationJsonString(JSONString);
            }
            //JSONString = placesApiStub.GetJSONString();
            //apiResults.addAccommodationJsonString(JSONString);

            //Get all dining JSON strings
            for(String s : diningList)
            {
                String url = GetURL(s, sLat, sLng);
                JSONString = getJSONFromURL(url);
                apiResults.addDiningJsonString(JSONString);
            }
            //JSONString = placesApiStub.GetJSONString();
            //apiResults.addDiningJsonString(JSONString);

            return apiResults;
        }

        @Override
        protected void onProgressUpdate(Void... values)
        {
            //Sets up and runs the progress spinner
            super.onProgressUpdate(values);
            progress = new ProgressDialog(LoadingSplashActivity.this);
            progress.setMessage("Downloading Place Data");
            progress.setIndeterminate(false);
            progress.setProgressStyle(ProgressDialog.STYLE_SPINNER);
            progress.setCancelable(false);
            progress.show();
        }

        @Override
        protected void onPostExecute(PlacesListStringResults details)
        {
            List<Place> attractionPlaces = getPlacesList(details.getAttractionJSONStringList());
            if(attractionPlaces != null)
            {
                placeDbSet.setPlaceListAttraction(attractionPlaces);
            }

            List<Place> diningPlaces = getPlacesList(details.getDiningJSONStringList());
            if(diningPlaces != null)
            {
                placeDbSet.setPlaceListDining(diningPlaces);
            }

            List<Place> accommodationPlaces = getPlacesList(details.getAccommodationJSONStringList());
            if(accommodationPlaces != null)
            {
                placeDbSet.setPlaceListAccommodation(accommodationPlaces);
            }

            Log.i("TAG", "API Request Finished");

            //Order Data
            placeDbSet.OrderData();

            //Stop progress spinner
            progress.cancel();

            //Move to main activity
            Intent i = new Intent(LoadingSplashActivity.this, MainActivity.class);
            i.putExtra("db", (Parcelable)placeDbSet);
            i.putExtra("latitude", latitude);
            i.putExtra("longitude", longitude);
            startActivity(i);
        }
    }



    private boolean HasResults(JSONObject obj)
    {
        boolean hasResult =  true;
        //Check if string has results
        try
        {
            String resultStatus = obj.getString("status");
            if(resultStatus.equals(ZERO_RESULTS))
            {
                hasResult = false;
            }
        }
        catch (JSONException e)
        {
            e.printStackTrace();
        }
        return hasResult;
    }

    //Takes an arrayList of JSON string and returns a list of places for each of them
    private List<Place> getPlacesList(ArrayList<String> JSONStringList)
    {
        List<Place> allPlaces = new ArrayList<Place>();

        //For each JSON String in the list
        for(String s : JSONStringList)
        {
            JSONObject obj = jPro.getJSONObjectFromString(s);
            boolean hasResults = HasResults(obj);
            if(hasResults)
            {
                JSONArray resultsArray = jPro.getJSONArrayFromJSONObject(obj, "results");
                int resultsLength = resultsArray.length();
                for(int i = 0; i < resultsLength; i++)
                {
                    try
                    {
                        //Get Place information from JSON object
                        JSONObject resultsObj = resultsArray.getJSONObject(i);
                        String id = resultsObj.getString("id");
                        String name = resultsObj.getString("name");
                        name = name.substring(0, 1).toUpperCase() + name.substring(1);      //Make sure that name has capital letter
                        String address = resultsObj.getString("vicinity");

                        //Unpack lat and lng out object
                        JSONObject geoObj = jPro.getJSONObjectFromJSONObject(resultsObj, "geometry");
                        JSONObject locationObj = jPro.getJSONObjectFromJSONObject(geoObj, "location");
                        double latitude = locationObj.getDouble("lat");
                        double longitude = locationObj.getDouble("lng");

                        //Grab first photo from array
                        JSONArray photoArray = jPro.getJSONArrayFromJSONObject(resultsObj, "photos");
                        String photoReference = "";
                        //Check that there is a photo
                        if(photoArray != null)
                        {
                            JSONObject photoObj = photoArray.getJSONObject(0);  //Get first photo object
                            photoReference = photoObj.getString("photo_reference");
                        }
                        else
                        {
                            photoReference = "null";
                        }


                        //Get Place types
                        JSONArray typesArray = jPro.getJSONArrayFromJSONObject(resultsObj, "types");
                        int typesLength = typesArray.length();
                        List<String> typesList = new ArrayList<String>();
                        for(int j = 0; j < typesLength; j++)
                        {
                            typesList.add(typesArray.getString(j));
                        }

                        //Check if the place has already been found
                        boolean NotInList = true;
                        for(Place p : allPlaces)
                        {
                            if(p.Name.equals(name))
                            {
                                NotInList = false;
                            }
                        }

                        if(NotInList)
                        {
                            Place newPlace = new Place(id, name, address, latitude, longitude, photoReference, typesList);
                            allPlaces.add(newPlace);
                        }
                    }
                    catch (JSONException e)
                    {
                        e.printStackTrace();
                    }
                }//end for
            }//end if HasResults

        }//end foreach

        return allPlaces;
    }

    //===============================================PLACES SEARCH TYPES====================================================//
    //Add a place type to the relevant list to search for it
    private ArrayList<String> FillAttractionList()
    {
        ArrayList<String> attractList = new ArrayList<String>();
        attractList.add("art_gallery");
        attractList.add("amusement_park");
        attractList.add("aquarium");
        attractList.add("bowling_alley");
        attractList.add("casino");
        attractList.add("zoo");
        attractList.add("university");
        attractList.add("stadium");
        attractList.add("spa");
        attractList.add("shopping_mall");
        attractList.add("pet_store");
        attractList.add("night_club");
        attractList.add("museum");
        attractList.add("movie_theater");
        return  attractList;
    }

    private ArrayList<String> FillDiningList()
    {
        ArrayList<String> diningList = new ArrayList<String>();
        diningList.add("bakery");
        diningList.add("bar");
        diningList.add("cafe");
        diningList.add("restaurant");
        return  diningList;
    }

    private ArrayList<String> FillAccommodationList()
    {
        ArrayList<String> accommoList = new ArrayList<String>();
        accommoList.add("campground");
        accommoList.add("lodging");
        accommoList.add("establishment");
        return  accommoList;
    }
}
