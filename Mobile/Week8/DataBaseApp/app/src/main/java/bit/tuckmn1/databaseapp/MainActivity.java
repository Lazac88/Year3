package bit.tuckmn1.databaseapp;

import android.content.res.AssetManager;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Adapter;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.Spinner;
import android.widget.Toast;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.util.ArrayList;

public class MainActivity extends AppCompatActivity
{

    SQLiteDatabase db;
    ArrayList<String> dbData;
    Spinner countrySpin;


    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //Initialize the database  (DB name, who can see it, what it returns if nothing found)
        db = openOrCreateDatabase("db", MODE_PRIVATE, null);

        createTable();

        //Get list of string for database input
        dbData = LoadStringArray("databaseEntries.txt");

        //Add data to table
        fullTable(dbData);

        //Find spinner
        countrySpin = (Spinner) findViewById(R.id.spinner);

        //Grab countryData
        ArrayList<String> countries = getCountryData();

        //Create an ArrayAdapter
        ArrayAdapter adapter = new ArrayAdapter(MainActivity.this, android.R.layout.simple_spinner_item, countries);

        // Apply the adapter to the spinner
        countrySpin.setAdapter(adapter);

        //Grab button
        Button citySearchButton = (Button) findViewById(R.id.btnCitySearch);
        citySearchButton.setOnClickListener(new buttonClickEventHandler());
    }

    public void createTable()
    {
        String tableCreate = "CREATE TABLE IF NOT EXISTS tblCity (" +
                             "cityID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                             "cityName TEXT NOT NULL, " +
                             "countryName TEXT NOT NULL);";

        //Execute the command
        db.execSQL((tableCreate));
    }

    public void fullTable(ArrayList<String> data)
    {
        String startText = "INSERT INTO tblCity VALUES(";
        String endText = ")";
        for(String tableData : data)
        {
            db.execSQL(startText + tableData + endText);
        }
    }

    public ArrayList<String> getAllData()
    {
        ArrayList<String> allData = new ArrayList<String>();
        String allQuery = "SELECT * FROM tblCity";
        Cursor returnData = db.rawQuery(allQuery, null);

        //Find number of return entries
        int count = returnData.getCount();

        //Grab the column numbers you require
        int cityNameIndex = returnData.getColumnIndex("cityName");
        int countryNameIndex = returnData.getColumnIndex("countryName");

        //Move cursor to first item in returnData
        returnData.moveToFirst();

        //Run though the return data and save to a list
        for(int i = 0; i < count; i++)
        {
            String cityName = returnData.getString(cityNameIndex);
            String countryName = returnData.getString(countryNameIndex);
            allData.add(cityName + ", " + countryName);

            //Move cursor
            returnData.moveToNext();
        }

        return allData;
    }

    public ArrayList<String> getCountryData()
    {
        ArrayList<String> allData = new ArrayList<String>();
        String countryQuery = "SELECT DISTINCT countryName FROM tblCity";
        Cursor returnData = db.rawQuery(countryQuery, null);

        //Find number of return entries
        int count = returnData.getCount();

        //Grab the column numbers you require
        int countryNameIndex = returnData.getColumnIndex("countryName");

        //Move cursor to first item in returnData
        returnData.moveToFirst();

        //Run though the return data and save to a list
        for(int i = 0; i < count; i++)
        {
            String countryName = returnData.getString(countryNameIndex);
            allData.add(countryName);

            //Move cursor
            returnData.moveToNext();
        }

        return allData;
    }

    public ArrayList<String> getCityDataFromCountry(String countryName)
    {
        ArrayList<String> cityData = new ArrayList<String>();
        String countryQuery = "SELECT DISTINCT cityName FROM tblCity WHERE countryName = ";
        String fullQuery = countryQuery + "'" + countryName + "'";
        Cursor returnData = db.rawQuery(fullQuery, null);

        //Find number of return entries
        int count = returnData.getCount();

        //Grab the column numbers you require
        int cityNameIndex = returnData.getColumnIndex("cityName");

        //Move cursor to first item in returnData
        returnData.moveToFirst();

        //Run though the return data and save to a list
        for(int i = 0; i < count; i++)
        {
            String cityName = returnData.getString(cityNameIndex);
            Log.i("City Names", cityName);
            cityData.add(cityName);

            //Move cursor
            returnData.moveToNext();
        }

        return cityData;
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

    public class buttonClickEventHandler implements View.OnClickListener
    {
        @Override
        public void onClick(View view)
        {
            String clickedItemString = countrySpin.getSelectedItem().toString();

            ArrayList<String> myCities = getCityDataFromCountry(clickedItemString);
            for(String i : myCities)
            {
                Log.i("myCitiesArray", i);
            }

            //Create an ArrayAdapter
            ArrayAdapter cityAdapter = new ArrayAdapter(MainActivity.this, android.R.layout.simple_spinner_item, myCities);

            //Grab ListView
            ListView cityList = (ListView) findViewById(R.id.cityListView);

            //Set results into ListView
            cityList.setAdapter(cityAdapter);
        }
    }
}
