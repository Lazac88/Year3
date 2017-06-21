package bit.tuckmn1.multipleactivities;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class SecondActivity extends AppCompatActivity
{

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        TextView text = (TextView) findViewById(R.id.myText);
        text.setText("This is activity 2");

        //Creating a reference to my button and creating an instance of my inner class which holds my event handlers
        Button myButton = (Button) findViewById(R.id.button);
        ButtonClickListener2 buttonClickDisplay = new ButtonClickListener2();

        //binding the instance of the inner class to my button
        myButton.setOnClickListener(buttonClickDisplay);
    }

    public class ButtonClickListener2 implements View.OnClickListener
    {
        @Override
        public void onClick(View view)
        {
            Intent changeActivity = new Intent(SecondActivity.this, ThirdActivity.class);
            startActivity(changeActivity);
        }
    }
}
