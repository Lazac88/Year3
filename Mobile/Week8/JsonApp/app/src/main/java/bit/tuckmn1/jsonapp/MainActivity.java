package bit.tuckmn1.jsonapp;

import android.content.res.AssetManager;
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

import java.io.IOException;
import java.io.InputStream;
import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    ListView itemList;
    Button fillList;
    ArrayList<DunedinEvent> myEvents;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        itemList = (ListView) findViewById(R.id.itemList);
        fillList = (Button) findViewById(R.id.button);
        fillList.setOnClickListener(new OnButtonClickHandler());
    }

    public class OnListClickHandler implements AdapterView.OnItemClickListener
    {
        @Override
        public void onItemClick(AdapterView<?> adapterView, View view, int i, long l)
        {
            Toast toast = Toast.makeText(MainActivity.this, myEvents.get(i).getDescription(), Toast.LENGTH_LONG);
            toast.show();
        }
    }

    public class OnButtonClickHandler implements View.OnClickListener
    {
        @Override
        public void onClick(View view)
        {
            String jsonAsString = getFileAsString("dunedin_events_2017.txt");
            JSONObject jsonObject = getJSONObjectFromString(jsonAsString);
            JSONObject events = getJSONObjectFromJSONObject(jsonObject, "events");
            JSONArray eventArray = getJSONArrayFromJSONObject(events, "event");
            myEvents = getListEventsFromJSONArray(eventArray);
            ArrayList<String> myTitles = getTitlesFromList(myEvents);

            //Make Adapter for ListView
            ArrayAdapter adapter = new ArrayAdapter(MainActivity.this, android.R.layout.simple_list_item_1, myTitles);
            itemList.setAdapter(adapter);
            itemList.setOnItemClickListener(new OnListClickHandler());
        }
    }

    public ArrayList<String> getTitlesFromList(ArrayList<DunedinEvent> myEvents)
    {
        ArrayList<String> myTitles = new ArrayList<String>();
        for(DunedinEvent de : myEvents)
        {
            myTitles.add(de.getTitle());
        }
        return myTitles;
    }

    public ArrayList<DunedinEvent> getListEventsFromJSONArray(JSONArray eventArray)
    {
        ArrayList<DunedinEvent> myEvents = new ArrayList<DunedinEvent>();
        int arrayLength = eventArray.length();

        //loop through each entry in the arrau and grab out relevant details
        for(int i = 0; i < arrayLength; i++)
        {
            try
            {
                JSONObject object = eventArray.getJSONObject(i);
                String title = object.getString("title");
                String description = object.getString("description");
                DunedinEvent event = new DunedinEvent(title, description, i);
                myEvents.add(event);
            }
            catch (JSONException e)
            {
                e.printStackTrace();
            }
        }
        return myEvents;
    }

    public String getFileAsString(String fileName)
    {
        String JSONInput = "";
        AssetManager am = getAssets();
        try
        {
            InputStream is = am.open(fileName);

            int fileSizeInBytes = is.available();
            byte[] JSONBuffer = new byte[fileSizeInBytes];

            is.read(JSONBuffer);
            is.close();

            JSONInput = new String(JSONBuffer);
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
        return JSONInput;
    }

    public JSONObject getJSONObjectFromJSONObject(JSONObject jsonObject, String objectKey)
    {
        JSONObject newJsonObject = null;
        try
        {
            newJsonObject = jsonObject.getJSONObject(objectKey);
        }
        catch (JSONException e)
        {
            e.printStackTrace();
        }
        return newJsonObject;
    }

    public JSONArray getJSONArrayFromJSONObject(JSONObject object, String objectKey)
    {
        //Make string into JSON object
        JSONArray newArray = null;
        try
        {
            newArray = object.getJSONArray(objectKey);
        }
        catch (JSONException e)
        {
            e.printStackTrace();
        }
        return  newArray;
    }

    public JSONObject getJSONObjectFromString(String jsonString)
    {
        //Make string into JSON object
        JSONObject object = null;
        try
        {
            object = new JSONObject(jsonString);
        }
        catch (JSONException e)
        {
            e.printStackTrace();
        }
        return  object;
    }
}
