package bit.tuckmn1.requestingdata;

import android.app.Activity;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        Button myButton = (Button) findViewById(R.id.btnChangeColour);
        myButton.setOnClickListener(new requestTextColourHandler());
    }

    public class requestTextColourHandler implements View.OnClickListener
    {

        @Override
        public void onClick(View v)
        {
            Intent changePage;

            changePage = new Intent(MainActivity.this, SettingsActivity.class);

            startActivityForResult(changePage, 0);
        }
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data)
    {
        if((requestCode == 0) && (resultCode == Activity.RESULT_OK))
        {
            int textColour = data.getIntExtra("textColour", 0);
            TextView myText = (TextView) findViewById(R.id.changeText);
            myText.setTextColor(textColour);
        }
    }
}
