package bit.tuckmn1.locationfinder;

import android.app.ProgressDialog;
import android.content.Context;
import android.content.pm.PackageManager;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.Drawable;
import android.location.Criteria;
import android.location.Location;
import android.location.LocationListener;
import android.location.LocationManager;
import android.os.AsyncTask;
import android.support.annotation.NonNull;
import android.support.v4.app.ActivityCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.Random;
import java.util.concurrent.ExecutionException;
import java.util.jar.Manifest;

public class MainActivity extends AppCompatActivity
{
    static final int LOCATION_REQ_CODE = 42;

    //JSON processor class
    private JSONProcessor jPro;

    //Instance of progress dialog
    ProgressDialog progress;

    //
    String sLat;
    String sLng;


    //=================================================GPS Variables===============================================//
    //Get a LocationManager
    LocationManager locationManager;
    //Get default Criteria
    Criteria defaultCriteria;
    //Get the provider name
    String providerName;
    int fineLocationOk;
    int coarseLocationOk;
    //=============================================================================================================//

    private TextView latitudeTextView;
    private TextView longitudeTextView;
    private TextView cityTextView;
    private ImageView cityImageView;

    private Bitmap cityImage;

    Random rand;


    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //Initialize the variables and find the view components
        jPro = new JSONProcessor();

        //=================================================GPS Variables===============================================//

        locationManager = (LocationManager) getSystemService(Context.LOCATION_SERVICE);
        defaultCriteria = new Criteria();

        //=============================================================================================================//

        rand = new Random();
        latitudeTextView = (TextView) findViewById(R.id.latNumberID);
        longitudeTextView = (TextView) findViewById(R.id.longNumberID);
        cityTextView = (TextView) findViewById(R.id.CityNameID);
        cityImageView = (ImageView) findViewById(R.id.cityImageView);

        cityImage = null;
        sLat = "";
        sLng = "";

        //Turn on polling
        boolean locationPermissionsOk = checkLocationPermission();
        if(locationPermissionsOk)
        {
            providerName = locationManager.getBestProvider(defaultCriteria, false);
            //Method Parameters: provider name string constant, time between checks in milliseconds, distance to move before update, our custion LocationUpdate event handler class
            locationManager.requestLocationUpdates(providerName, 400, 1, new CustomLocationListener());
        }
        else
        {
            requestLocationPermission();
        }
    }


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
                //Approved style is to check twice
                checkLocationPermission();

                providerName = locationManager.getBestProvider(new Criteria(), false);
                locationManager.requestLocationUpdates(providerName, 400, 1, new CustomLocationListener());
            }
            else
            {
                //Permission Denied
                //TODO set bool flag. Don't continue to run app until permissions granted
            }
        }
        else
        {
            //User pressed back button during permissions
        }
    }

    private class CustomLocationListener implements LocationListener
    {
        @Override
        public void onLocationChanged(Location location)
        {
            //Pull the individual data values from the passed in new Location
            double lat = location.getLatitude();
            double lng = location.getLongitude();
            sLat = Double.toString(lat);
            sLng = Double.toString(lng);

            //Update TextViews with location
            latitudeTextView.setText(sLat);
            longitudeTextView.setText(sLng);

            AsyncAPIShowRawJSON asyncAPIShowRawJSON = new AsyncAPIShowRawJSON();
            String url = createGeopluginURLString(sLat, sLng);
            asyncAPIShowRawJSON.execute(url);
        }

        @Override
        public void onStatusChanged(String provider, int status, Bundle extras)
        {

        }

        @Override
        public void onProviderEnabled(String provider)
        {

        }

        @Override
        public void onProviderDisabled(String provider)
        {

        }
    }

    //Creates a URL for the geoplugin API
    public String createGeopluginURLString(String lat, String longitude)
    {
        String url = "http://www.geoplugin.net/extras/location.gp?lat=";
        url += lat;
        url += "&long=";
        url += longitude;
        url += "&format=json";
        return url;
    }

    class AsyncAPIShowRawJSON extends AsyncTask<String, Void, LocationDetails>
    {
        @Override
        protected LocationDetails doInBackground(String... params)
        {
            String JSONString = null;

            //Start progress spinner
            publishProgress();

            String url = params[0];

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

            //Create a LocationDetails instance to return to onPostExecute
            LocationDetails details = new LocationDetails(JSONString, sLat, sLng);
            return details;
        }

        @Override
        protected void onProgressUpdate(Void... values)
        {
            //Sets up and runs the progress spinner
            super.onProgressUpdate(values);
            progress = new ProgressDialog(MainActivity.this);
            progress.setMessage("Finding location");
            progress.setIndeterminate(false);
            progress.setProgressStyle(ProgressDialog.STYLE_SPINNER);
            progress.show();
        }

        @Override
        protected void onPostExecute(LocationDetails details)
        {
            //Stop progress spinner
            progress.cancel();
            String JSONString = details.getJSONString();
            String city = "";

            //Check if geoplugin has returned a city
            if(!JSONString.equals("[[]]"))
            {
                //Get information from returned JSON String
                JSONObject returnedObject = jPro.getJSONObjectFromString(details.getJSONString());

                try
                {
                    city = returnedObject.getString("geoplugin_place");
                }
                catch (JSONException e)
                {
                    e.printStackTrace();
                }
                //Set city text view
                cityTextView.setText(city);

                //Call AsyncAPIGetCityImage
                AsyncAPIGetCityImage getImage = new AsyncAPIGetCityImage();
                getImage.execute(city);
            }
            else
            {
                cityTextView.setText("No city avaliable at this location");
                Drawable image = MainActivity.this.getResources().getDrawable(R.drawable.noimage);
                cityImageView.setImageDrawable(image);
            }
        }
    }

    //Async Call to get city image
    class AsyncAPIGetCityImage extends AsyncTask<String, Void, String>
    {
        @Override
        protected String doInBackground(String... params)
        {
            String cityName = params[0];
            String JSONString = null;
            String url = CreateFlickrURL(cityName);

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
                if (resCode == 200)
                {
                    InputStream is = connection.getInputStream();
                    InputStreamReader isr = new InputStreamReader(is);
                    BufferedReader br = new BufferedReader(isr);
                    //Read the input
                    String responseString;
                    StringBuilder stringBuilder = new StringBuilder();
                    while ((responseString = br.readLine()) != null)
                    {
                        stringBuilder = stringBuilder.append(responseString);
                    }
                    //Get the string from the stringBuilder
                    JSONString = stringBuilder.toString();
                }
            } catch (Exception e)
            {
                e.printStackTrace();
            }
            return JSONString;
        }

        @Override
        protected void onPostExecute(String JSONString)
        {
            //Unpack the json string received
            JSONObject jObject = jPro.getJSONObjectFromString(JSONString);
            JSONObject photosObject = jPro.getJSONObjectFromJSONObject(jObject, "photos");
            String numResults = "";
            try
            {
                numResults = photosObject.getString("total");
            }
            catch (JSONException e)
            {
                e.printStackTrace();
            }
            if (numResults.equals("0"))
            {
                Drawable image = MainActivity.this.getResources().getDrawable(R.drawable.noimage);
                cityImageView.setImageDrawable(image);
            }
            else
            {
                JSONArray jArray = jPro.getJSONArrayFromJSONObject(photosObject, "photo");
                JSONObject cityResult = null;
                String id = "";
                String secret = "";
                String server = "";
                String farm = "";
                //get details from final object
                try
                {
                    cityResult = jArray.getJSONObject(0);
                    id = cityResult.getString("id");
                    secret = cityResult.getString("secret");
                    server = cityResult.getString("server");
                    farm = cityResult.getString("farm");
                } catch (JSONException e)
                {
                    e.printStackTrace();
                }

                //Create url for image
                String imageURL = CreateFlickrImageURL(id, secret, server, farm);
                //Final ASYNC call to get image and set it as bitmap
                AsyncGetImageBitmap asyncGetImageBitmap = new AsyncGetImageBitmap();
                asyncGetImageBitmap.execute(imageURL);
                try
                {
                    asyncGetImageBitmap.get();
                } catch (InterruptedException e)
                {
                    e.printStackTrace();
                } catch (ExecutionException e)
                {
                    e.printStackTrace();
                }

                cityImageView.setImageBitmap(cityImage);
            }
        }

        //Create the URL to find a city
        private String CreateFlickrURL(String cityName)
        {
            String url = "https://api.flickr.com/services/rest/?method=flickr.photos.search&api_key=eda41a123d459be0f85276d37290651e&tags=" + cityName + "&format=json&content_type=1&per_page=1&nojsoncallback=1";
            return url;
        }

        //Create the url to display an image
        private String CreateFlickrImageURL(String id, String secret, String server, String farm)
        {
            String url = "https://farm" + farm + ".staticflickr.com/" + server + "/" + id + "_" + secret + ".jpg";
            return url;
        }
    }

    class AsyncGetImageBitmap extends AsyncTask<String, Void, Bitmap>
    {
        @Override
        protected Bitmap doInBackground(String... params)
        {
            //Declare here so not local to the try block
            String JSONString = null;
            String artistURL = params[0];
            //Bitmap artistImage = null;

            HttpURLConnection connection = null;
            try
            {
                //Convert URL string to URLObject
                URL URLObject = new URL(artistURL);

                //Create HttpURLConnection object via openConnection command
                connection = (HttpURLConnection) URLObject.openConnection();

                //Send the URL
                connection.connect();

                //Grab response code and check if response is successful
                int resCode = connection.getResponseCode();
                if (resCode == 200)
                {
                    InputStream is = connection.getInputStream();
                    cityImage = BitmapFactory.decodeStream(is);
                }
            }
            catch (Exception e)
            {
                Log.i("URL EXCEPTION", "Getting bitmap image failed");
                e.printStackTrace();
                connection.disconnect();
                return null;
            }
            Log.i("TAG", cityImage.toString());

            return cityImage;
        }

        @Override
        protected void onPostExecute(Bitmap fetchedBitmap)
        {
            Log.i("TAG", "Setting fetchedBitmap to global variable");
            //Set bitmap to global
            cityImage = fetchedBitmap;
        }
    }
}
