package bit.tuckmn1.weekoneproject2;

import android.content.res.Resources;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

import java.util.Random;

public class MainActivity extends AppCompatActivity
{

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        //grabs data from parent class
        super.onCreate(savedInstanceState);
        //Passes an int reference of the main activity
        setContentView(R.layout.activity_main);

        //Every time the app is "onCreate" it will pick a random breed of dog
        String breed = pickBreed();

        //Creates a TextView.
        // Uses findViewById to get the int reference to the TextView in activityMain.xml
        // Casts the int reference into the data type we need
        TextView breedText = (TextView) findViewById(R.id.MainText);
        breedText.setText(breed);

        TextView arrayText = (TextView) findViewById(R.id.ArrayText);
        Resources rr = getResources();
        int datesArray[] = rr.getIntArray(R.array.FebFridays);
        arrayText.setText(createDateString(datesArray));
    }

    public String createDateString(int datesArray[])
    {
        String myDates = "Febuary Fridays are on: ";
        for(int date : datesArray)
        {
            myDates += date + " ";
        }
        return myDates;
    }

    //Method that creates a random number and returns a dog breed String based on that result
    public String pickBreed()
    {
        Random rand = new Random();
        int number = rand.nextInt(4);
        String breed = "";
        switch(number)
        {
            case 0:
                breed = "Poodle";
                break;
            case 1:
                breed = "Lab";
                break;
            case 2:
                breed = "Shar Pei";
                break;
            case 3:
                breed = "Newfoundland";
                break;
        }
        return breed;
    }
}
