package bit.tuckmn1.getsimilarartists;

import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Adapter;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;

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
    Button btnSearch;
    ListView similarArtistListView;
    EditText userInput;

    ArrayList<Artists> myArtists;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        jPro = new JSONProcessor();
        btnSearch = (Button) findViewById(R.id.btnSearch);
        similarArtistListView = (ListView) findViewById(R.id.listView_SimilarArtists);
        userInput = (EditText) findViewById(R.id.editText);

        myArtists = new ArrayList<Artists>();

        btnSearch.setOnClickListener(new OnButtonClickEventHandler());
    }

    public class OnButtonClickEventHandler implements View.OnClickListener
    {
        @Override
        public void onClick(View view)
        {
            String input = userInput.getText().toString();
            AsyncAPIShowRawJSON APIThread = new AsyncAPIShowRawJSON();
            APIThread.execute(input);
        }
    }

    class AsyncAPIShowRawJSON extends AsyncTask<String, Void, String>
    {
        @Override
        protected String doInBackground(String... params)
        {
            //Declare here so not local to the try block
            String JSONString = null;
            String artist = params[0];
            try
            {
                String url = "http://ws.audioscrobbler.com/2.0/?method=artist.getSimilar&artist=" + artist + "&api_key=58384a2141a4b9737eacb9d0989b8a8c&limit=10&format=json";

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
            JSONObject similarArtistsObject = jPro.getJSONObjectFromJSONObject(returnedObject, "similarartists");
            JSONArray artistsArray = jPro.getJSONArrayFromJSONObject(similarArtistsObject, "artist");
            ArrayList<Artists> similarArtists = getArtistsFromJSONArray(artistsArray);
            myArtists = similarArtists;

            ArrayList<String> artistNames = new ArrayList<String>();
            for(Artists a : similarArtists)
            {
                artistNames.add(a.getName());
            }

            //Make Adapter for ListView
            ArrayAdapter adapter = new ArrayAdapter(MainActivity.this, android.R.layout.simple_list_item_1, artistNames);
            similarArtistListView.setAdapter(adapter);
            //similarArtistListView.setOnItemClickListener(new OnListClickHandler());
        }
    }

    public ArrayList<Artists> getArtistsFromJSONArray(JSONArray artistArray)
    {
        ArrayList<Artists> myArtists = new ArrayList<Artists>();
        int arrayLength = artistArray.length();

        //loop through each entry in the arrau and grab out relevant details
        for(int i = 0; i < arrayLength; i++)
        {
            try
            {
                JSONObject object = artistArray.getJSONObject(i);
                String artistName = object.getString("name");
                String url = object.getString("url");
                JSONArray imageArray = jPro.getJSONArrayFromJSONObject(object, "image");
                JSONObject largeImage = imageArray.getJSONObject(2);
                String imageURL = largeImage.getString("#text");

                Artists artist = new Artists(artistName, url , imageURL, i);
                myArtists.add(artist);
            }
            catch (JSONException e)
            {
                e.printStackTrace();
            }
        }
        return myArtists;
    }
}
