package bit.tuckmn1.iopractical;

import android.content.res.AssetManager;
import android.os.Message;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.Spinner;
import android.widget.Toast;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.util.ArrayList;

public class MainActivity extends AppCompatActivity
{
    ArrayList<String> myCities;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Spinner spinner = (Spinner) findViewById(R.id.spinner);

        //Get string array of cities
        myCities = LoadStringArray("cities.txt");
        // Create an ArrayAdapter using the string array and a default spinner layout
        ArrayAdapter adapter = new ArrayAdapter(MainActivity.this, android.R.layout.simple_spinner_item, myCities);
        // Apply the adapter to the spinner
        spinner.setAdapter(adapter);
    }

    public ArrayList<String> LoadStringArray(String textFileName)
    {
        ArrayList<String> returnList = new ArrayList<String>();

        //Grab an AssetManager
        AssetManager am = getAssets();

        try
        {
            //Set up IO Stream
            InputStream is = am.open(textFileName);
            InputStreamReader ir = new InputStreamReader(is);
            BufferedReader br = new BufferedReader(ir);

            //Read in text file
            String currentString;
            while((currentString = br.readLine()) != null)
            {
                returnList.add(currentString);
            }
            br.close();
        }catch (IOException e)
        {
            Toast toast = Toast.makeText(this, e.getMessage(), Toast.LENGTH_SHORT);
        }

        return returnList;
    }
}
