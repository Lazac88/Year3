package bit.tuckmn1.multipleactivities;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity
{

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //Creating a reference to my button and creating an instance of my inner class which holds my event handlers
        Button myButton = (Button) findViewById(R.id.button);
        ButtonClickListener1 buttonClickDisplay = new ButtonClickListener1();

        //binding the instance of the inner class to my button
        myButton.setOnClickListener(buttonClickDisplay);
    }

    public class ButtonClickListener1 implements View.OnClickListener
    {
        @Override
        public void onClick(View view)
        {
            Intent changeActivity = new Intent(MainActivity.this, SecondActivity.class);
            startActivity(changeActivity);
        }
    }
}
