package bit.tuckmn1.multipleactivities;

import android.content.Intent;
import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class ThirdActivity extends AppCompatActivity
{

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        TextView text = (TextView) findViewById(R.id.myText);
        text.setText("This is activity 3");

        //Creating a reference to my button and creating an instance of my inner class which holds my event handlers
        Button myButton = (Button) findViewById(R.id.button);
        ButtonClickListener3 buttonClickDisplay = new ButtonClickListener3();

        //binding the instance of the inner class to my button
        myButton.setOnClickListener(buttonClickDisplay);
    }

    public class ButtonClickListener3 implements View.OnClickListener
    {
        @Override
        public void onClick(View view)
        {
            Uri goToWebsite = Uri.parse("https://developer.android.com/training/basics/firstapp/starting-activity.html");
            Intent implicitIntent = new Intent(Intent.ACTION_VIEW, goToWebsite);
            startActivity(implicitIntent);
        }
    }
}
