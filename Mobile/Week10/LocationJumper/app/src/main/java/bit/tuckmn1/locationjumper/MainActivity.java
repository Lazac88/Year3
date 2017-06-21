package bit.tuckmn1.locationjumper;

import android.app.ProgressDialog;
import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.Drawable;
import android.os.AsyncTask;
import android.support.v4.content.ContextCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;
import org.w3c.dom.Text;

import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.text.DecimalFormat;
import java.util.Random;
import java.util.concurrent.ExecutionException;

public class MainActivity extends AppCompatActivity
{
    //Lat and long constants
    private final int LATITUDE = 90;
    private final int LONGITUDE = 180;

    //JSON processor class
    private JSONProcessor jPro;

    //Instance of progress dialog
    ProgressDialog progress;

    private Button teleportBtn;
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

        rand = new Random();
        teleportBtn = (Button) findViewById(R.id.btnTeleport);
        latitudeTextView = (TextView) findViewById(R.id.latNumberID);
        longitudeTextView = (TextView) findViewById(R.id.longNumberID);
        cityTextView = (TextView) findViewById(R.id.CityNameID);
        cityImageView = (ImageView) findViewById(R.id.cityImageView);

        cityImage = null;

        //Set button click listener
        teleportBtn.setOnClickListener(new onButtonClickEventHandler());
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

    //Creates a URL for the geoplugin API
    public String createURLString(String lat, String longitude)
    {
        String url = "http://www.geoplugin.net/extras/location.gp?lat=";
        url += lat;
        url += "&long=";
        url += longitude;
        url += "&format=json";
        return url;
    }

    //Button click handler. Fires off a geoplugin request
    public class onButtonClickEventHandler implements View.OnClickListener
    {
        @Override
        public void onClick(View view)
        {
            AsyncAPIShowRawJSON APIThread = new AsyncAPIShowRawJSON();
            APIThread.execute();
        }
    }

    class AsyncAPIShowRawJSON extends AsyncTask<Void, Void, LocationDetails>
    {
        @Override
        protected LocationDetails doInBackground(Void... voids)
        {
            boolean blank = true;
            String JSONString = null;
            String sLat = "";
            String sLong = "";

            //Start progress spinner
            publishProgress();

            //Will keep searching for a latitude and longitude that returns a city
            while(blank)
            {

                double latitude = getRandomNumber(LATITUDE);
                double longitude = getRandomNumber(LONGITUDE);
                sLat = Double.toString(latitude);
                sLong = Double.toString(longitude);

                String url = createURLString(sLat, sLong);

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
                    //Check if geoplugin has returned a city
                    if(!JSONString.equals("[[]]"))
                    {
                        blank = false;
                    }
                }
                catch(Exception e)
                {
                    e.printStackTrace();
                }
            }

            LocationDetails details = new LocationDetails(JSONString, sLat, sLong);
            return details;
        }

        @Override
        protected void onPostExecute(LocationDetails details)
        {
            //Stop progress spinner
            progress.cancel();

            //Update TextViews
            latitudeTextView.setText(details.getLatitude());
            longitudeTextView.setText(details.getLongitude());

            //Get information from returned JSON String
            JSONObject returnedObject = jPro.getJSONObjectFromString(details.getJSONString());
            String city = "";

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

            //TODO call AsyncAPIGetCityImage
            AsyncAPIGetCityImage getImage = new AsyncAPIGetCityImage();
            getImage.execute(city);
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
    }

    //Async Call to get city image
    class AsyncAPIGetCityImage extends AsyncTask<String, Void, String> {
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

        @Override
        protected void onPostExecute(String JSONString)
        {
            //Unpack the json string recieved
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
            if(numResults.equals("0"))
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
                }
                catch (JSONException e)
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
                }
                catch (InterruptedException e)
                {
                    e.printStackTrace();
                }
                catch (ExecutionException e)
                {
                    e.printStackTrace();
                }

                cityImageView.setImageBitmap(cityImage);
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

        //Create the URL to find a city
        private String CreateFlickrURL(String cityName)
        {
            String url = "https://api.flickr.com/services/rest/?method=flickr.photos.search&api_key=eda41a123d459be0f85276d37290651e&tags=" + cityName +"&format=json&content_type=1&per_page=1&nojsoncallback=1";
            return url;
        }

        //Create the url to display an image
        private String CreateFlickrImageURL(String id, String secret, String server, String farm)
        {
            String url = "https://farm" + farm + ".staticflickr.com/" + server + "/" + id + "_" + secret + ".jpg";
            return url;
        }
    }
}
