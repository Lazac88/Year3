package bit.tuckmn1.attractionfinder2;

import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.app.ProgressDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.AsyncTask;
import android.os.Bundle;
import android.app.Fragment;
import android.os.Parcelable;
import android.support.v4.content.ContextCompat;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.util.Log;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import com.google.android.gms.maps.model.LatLng;

import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.Collections;
import java.util.List;

import static android.R.attr.defaultValue;

public class MainActivity extends AppCompatActivity
{
    //Instance of progress dialog
    ProgressDialog progress;

    private Toolbar toolbar;
    private Button btnList;
    private Button btnMap;

    //Current position
    private double latitude;
    private double longitude;

    private PlaceDbSet placeDbSet;
    private List<Place> myPlaces;

    private boolean isMap;

    //Save list item user was viewing
    private int selectedListItem;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.content_main);

        //Get data from loading screen
        Intent i = getIntent();
        placeDbSet = (PlaceDbSet) i.getParcelableExtra("db");
        myPlaces = placeDbSet.getPlaceListAttraction();
        latitude = i.getDoubleExtra("latitude", defaultValue);
        longitude = i.getDoubleExtra("longitude", defaultValue);

        //Set Images
        checkImageDownload();

        //Find and set the tool bar
        toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        //Get buttons and set click listeners
        btnList = (Button) findViewById(R.id.btnList);
        btnList.setOnClickListener(new onListButtonClickHandler());
        btnMap = (Button) findViewById(R.id.btnMap);
        btnMap.setOnClickListener(new onMapButtonClickHandler());

        isMap = true;

        selectedListItem = 0;

        //Start Map Fragment as default
        StartMapFragment();
    }

    //Get and set list item focus
    public void setSelectedListItem(int position)
    {
        selectedListItem = position;
    }

    public int getSelectedListItem()
    {
        return selectedListItem;
    }

    //Alret Dialog To check if the user wants to download images
    public void checkImageDownload()
    {
        new AlertDialog.Builder(this)
                .setTitle("Images")
                .setMessage("Do you want to download Place Images? \n This will use data and take time")
                .setNegativeButton("No", null)
                .setPositiveButton("Yes", new onYesToDownloadImagesHandler())
                .create().show();
    }

    public class onYesToDownloadImagesHandler implements DialogInterface.OnClickListener
    {
        @Override
        public void onClick(DialogInterface dialog, int which)
        {
            //Set place images
            AsyncAPIGetPlaceImage getImages = new AsyncAPIGetPlaceImage();
            getImages.execute();
        }
    }

    //Method that gets selected place from fragment and launches details fragment
    public void LaunchDetailsFragment(Place p)
    {
        Fragment dynamicFragment = new DetailsFragment();
        FragmentManager fm = getFragmentManager();
        Bundle placeBundle = new Bundle();
        placeBundle.putParcelable("place", p);
        dynamicFragment.setArguments(placeBundle);

        FragmentTransaction ft = fm.beginTransaction();
        ft.replace(R.id.fragHolder, dynamicFragment);
        ft.commit();
    }

    //Method to get data to fragment
    public List<Place> getMyData()
    {
        return myPlaces;
    }

    //Method to get current location to fragment
    public LatLng getCurrentLocation() { return new LatLng(latitude, longitude);}

    public class onListButtonClickHandler implements View.OnClickListener
    {
        @Override
        public void onClick(View v)
        {
            isMap = false;
            StartListFragment();
        }
    }

    public class onMapButtonClickHandler implements View.OnClickListener
    {
        @Override
        public void onClick(View v)
        {
            isMap = true;
            StartMapFragment();
        }
    }

    public void StartListFragment()
    {
        Fragment dynamicFragment = new PlacesListFragment();
        FragmentManager fm = getFragmentManager();

        FragmentTransaction ft = fm.beginTransaction();
        ft.replace(R.id.fragHolder, dynamicFragment);
        ft.commit();
    }

    public void StartMapFragment()
    {
        Fragment dynamicFragment = new MapsFragment();
        FragmentManager fm = getFragmentManager();

        FragmentTransaction ft = fm.beginTransaction();
        ft.replace(R.id.fragHolder, dynamicFragment);
        ft.commit();
    }

    private void StartFragmentType(boolean isMap)
    {
        if(isMap)
        {
            StartMapFragment();
        }
        else
        {
            StartListFragment();
        }
    }

    private boolean memoryIsFull = false;

    class AsyncAPIGetPlaceImage extends AsyncTask<Void, Void, Bitmap>
    {
        private Bitmap getBitmapFromURL(String url)
        {
            Bitmap placeImage = null;
            HttpURLConnection connection = null;
            try
            {
                //Convert URL string to URLObject
                URL URLObject = new URL(url);

                //Create HttpURLConnection object via openConnection command
                connection = (HttpURLConnection) URLObject.openConnection();

                //Send the URL
                connection.connect();

                //Grab response code and check if response is successful
                int resCode = connection.getResponseCode();
                if(resCode == 200)
                {
                    InputStream is = connection.getInputStream();
                    placeImage = BitmapFactory.decodeStream(is);
                }
            }
            catch(Exception e)
            {
                Log.i("URL EXCEPTION", "Getting bitmap image failed");
                e.printStackTrace();
                connection.disconnect();
                Bitmap noPic = BitmapFactory.decodeResource(getApplicationContext().getResources(), R.drawable.rubber_duck);
                placeImage = noPic;

            }
            catch(OutOfMemoryError e)
            {
                memoryIsFull = true;
                Bitmap noPic = BitmapFactory.decodeResource(getApplicationContext().getResources(), R.drawable.rubber_duck);
                placeImage = noPic;
            }
            return placeImage;
        }

        private String getImageUrl(String imageReference)
        {
            String url = "https://maps.googleapis.com/maps/api/place/photo?maxwidth=600&photoreference=" + imageReference + "&key=AIzaSyBOm2SY3mY9Awm8qmxoIMWT236M3bGZB8k";
            return url;
        }

        @Override
        protected Bitmap doInBackground(Void... params)
        {
            //Start progress spinner
            publishProgress();

            Bitmap placeImage = null;
            //Get images for attractions
            for(Place p : placeDbSet.getPlaceListAttraction())
            {
                //Get Image Reference
                String imageRef = p.getPhotoReference();
                if(!imageRef.equals("null") && !memoryIsFull)
                {
                    String url = getImageUrl(imageRef);
                    placeImage = getBitmapFromURL(url);
                    p.setPlaceImage(placeImage);
                }
            }

            //Get images for accommodation
            for(Place p : placeDbSet.getPlaceListAccommodation())
            {
                //Get Image Reference
                String imageRef = p.getPhotoReference();
                if(!imageRef.equals("null") && !memoryIsFull)
                {
                    String url = getImageUrl(imageRef);
                    placeImage = getBitmapFromURL(url);
                    p.setPlaceImage(placeImage);
                }
            }

            //Get images for dining
            for(Place p : placeDbSet.getPlaceListDining())
            {
                //Get Image Reference
                String imageRef = p.getPhotoReference();
                if(!imageRef.equals("null") && !memoryIsFull)
                {
                    String url = getImageUrl(imageRef);
                    placeImage = getBitmapFromURL(url);
                    p.setPlaceImage(placeImage);
                }
            }
            return placeImage;
        }

        @Override
        protected void onProgressUpdate(Void... values)
        {
            //Sets up and runs the progress spinner
            super.onProgressUpdate(values);
            progress = new ProgressDialog(MainActivity.this);
            progress.setMessage("Downloading Images...\n\nTap Outside This Box To Use The App \n\nThe Images Will Continue To Load");
            progress.setIndeterminate(false);
            progress.setProgressStyle(ProgressDialog.STYLE_SPINNER);
            progress.show();
        }

        @Override
        protected void onPostExecute(Bitmap bitmap)
        {
            //Stop progress spinner
            progress.cancel();
            ShowImagesFinishedDownloading();
        }
    }

    //Provide user feedback
    public void ShowImagesFinishedDownloading()
    {
        if(memoryIsFull)
        {
            //Alert the user that the images stopped due to lack of phone memory
            Toast.makeText(this, "Images Stopped Downloading Due To Insufficient Memory", Toast.LENGTH_LONG).show();
        }
        else
        {
            Toast.makeText(this, "Image Download Complete", Toast.LENGTH_LONG).show();
        }

    }

    //Stops user from going back to the splash screen where they get stuck
    @Override
    public void onBackPressed()
    {
        //Do Nothing
    }

    //===================================TOOLBAR METHODS============================//
    //This method add the icons in res/menu/menu_icons to the toolbar
    @Override
    public boolean onCreateOptionsMenu(Menu menu)
    {
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.menu_icons, menu);
        return true;
    }

    //This method accepts a Menu item of the toolbar button clicked
    //Can access the id (defined in the xml file) with item.getItemId()
    @Override
    public boolean onOptionsItemSelected(MenuItem item)
    {
        switch (item.getItemId()) {
            // action with ID accomodation was selected
            case R.id.accomodation:
                myPlaces = placeDbSet.getPlaceListAccommodation();
                StartFragmentType(isMap);
                Toast.makeText(this, "Accommodation selected", Toast.LENGTH_SHORT)
                        .show();
                break;
            // action with ID attraction was selected
            case R.id.attraction:
                myPlaces = placeDbSet.getPlaceListAttraction();
                StartFragmentType(isMap);
                Toast.makeText(this, "Attraction selected", Toast.LENGTH_SHORT)
                        .show();
                break;
            // action with ID dining was selected
            case R.id.dining:
                myPlaces = placeDbSet.getPlaceListDining();
                StartFragmentType(isMap);
                Toast.makeText(this, "Dining selected", Toast.LENGTH_SHORT)
                        .show();
                break;
            default:
                break;
        }
        return true;
    }
}
