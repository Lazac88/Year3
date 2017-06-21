package bit.tuckmn1.topartists;

import android.app.FragmentManager;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.Toast;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.ArrayList;

public class MainActivity extends AppCompatActivity
{
    JSONProcessor jPro;
    ArrayList<Track> myTopTracks;
    ArrayList<Artist> myTopArtists;
    ListView topArtistList;
    Button fillListBtn;
    ArtistImageFragment frag;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        jPro = new JSONProcessor();
        myTopTracks = new ArrayList<Track>();
        myTopArtists = new ArrayList<Artist>();
        topArtistList = (ListView) findViewById(R.id.topArtistsList);
        fillListBtn = (Button) findViewById(R.id.FillList);

        fillListBtn.setOnClickListener(new ButtonClickEventHandler());
    }


    class AsyncAPIShowRawJSON extends AsyncTask<Void, Void, String>
    {
        @Override
        protected String doInBackground(Void... voids)
        {
            //Declare here so not local to the try block
            String JSONString = null;
            try
            {
                String url = "http://ws.audioscrobbler.com/2.0/?method=chart.getTopArtists&api_key=58384a2141a4b9737eacb9d0989b8a8c&limit=20&format=json";

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
        protected void onPostExecute(String fetchedString)
        {
            JSONObject returnedObject = jPro.getJSONObjectFromString(fetchedString);
            JSONObject topArtistsObject = jPro.getJSONObjectFromJSONObject(returnedObject, "artists");
            JSONArray artistsArray = jPro.getJSONArrayFromJSONObject(topArtistsObject, "artist");
            myTopArtists = getArtistsFromJSONArray(artistsArray);

            //Make ArtistListAdapter for ListView
            ArtistListAdapter adapter = new ArtistListAdapter(MainActivity.this, myTopArtists);
            topArtistList.setAdapter(adapter);

            //Make List Clickable
            topArtistList.setOnItemClickListener(new OnListClickHandler());

            //Code Below is for top tracks
            /*
            JSONObject returnedObject = jPro.getJSONObjectFromString(fetchedString);
            JSONObject topTracksObject = jPro.getJSONObjectFromJSONObject(returnedObject, "toptracks");
            JSONArray tracksArray = jPro.getJSONArrayFromJSONObject(topTracksObject, "track");
            myTopTracks = getTracksFromJSONArray(tracksArray);

            //Make TrackListAdapter for ListView
            TrackListAdapter adapter = new TrackListAdapter(MainActivity.this, myTracks);
            topTracksList.setAdapter(adapter);

            //Make List Clickable
            //topTracksList.setOnItemClickListener(new OnListClickHandler());
            */
        }
    }

    private class OnListClickHandler implements AdapterView.OnItemClickListener
    {
        @Override
        public void onItemClick(AdapterView<?> adapterView, View view, int i, long l)
        {
            //Code here to make list things happen
            Toast.makeText(getApplicationContext(), "Clicked Product ID=" + view.getTag(), Toast.LENGTH_LONG).show();
            int artistID = (int)view.getTag();
            Artist clickedArtist = myTopArtists.get(artistID);
            String artistImageURL = clickedArtist.getImageURl();

            //Create bundle that holds drawable
            Bundle myBundle = new Bundle();
            myBundle.putString("imgURL", artistImageURL);

            FragmentManager fm = getFragmentManager();
            frag = new ArtistImageFragment();
            frag.setArguments(myBundle);
            frag.show(fm, "image");
        }
    }



    public class ButtonClickEventHandler implements View.OnClickListener
    {
        @Override
        public void onClick(View view)
        {
            AsyncAPIShowRawJSON APIThread = new AsyncAPIShowRawJSON();
            APIThread.execute();
        }
    }

    public ArrayList<Artist> getArtistsFromJSONArray(JSONArray artistsArray)
    {
        ArrayList<Artist> myArtistsList = new ArrayList<Artist>();
        int arrayLength = artistsArray.length();

        //loop through each entry in the array and grab out relevant details
        for(int i = 0; i < arrayLength; i++)
        {
            try
            {
                JSONObject object = artistsArray.getJSONObject(i);
                String artistName = object.getString("name");
                int listenerCount = object.getInt("listeners");

                JSONArray imageArray = jPro.getJSONArrayFromJSONObject(object, "image");
                JSONObject largeImage = imageArray.getJSONObject(2);
                String imageURL = largeImage.getString("#text");

                Artist artist = new Artist(artistName, listenerCount, imageURL, i);
                myArtistsList.add(artist);
            }
            catch (JSONException e)
            {
                e.printStackTrace();
            }
        }
        return myArtistsList;
    }

    public ArrayList<Track> getTracksFromJSONArray(JSONArray tracksArray)
    {
        ArrayList<Track> myTracks = new ArrayList<Track>();
        int arrayLength = tracksArray.length();

        //loop through each entry in the array and grab out relevant details
        for(int i = 0; i < arrayLength; i++)
        {
            try
            {
                JSONObject object = tracksArray.getJSONObject(i);
                String trackName = object.getString("name");
                int listenerCount = object.getInt("listeners");
                JSONObject artist = jPro.getJSONObjectFromJSONObject(object, "artist");
                String artistName = artist.getString("name");
                JSONArray imageArray = jPro.getJSONArrayFromJSONObject(object, "image");
                JSONObject largeImage = imageArray.getJSONObject(2);
                String imageURL = largeImage.getString("#text");

                Track track = new Track(trackName, listenerCount, artistName, imageURL, i);
                myTracks.add(track);
            }
            catch (JSONException e)
            {
                e.printStackTrace();
            }
        }
        return myTracks;
    }
}
