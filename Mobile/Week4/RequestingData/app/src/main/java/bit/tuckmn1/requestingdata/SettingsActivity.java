package bit.tuckmn1.requestingdata;

import android.app.Activity;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.EditText;
import android.widget.TextView;

public class SettingsActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_settings);

        Intent returnIntent;

        returnIntent = new Intent(SettingsActivity.this, MainActivity.class);

        TextView id = (TextView) findViewById(R.id.colourText);

        int textColour = id.getCurrentTextColor();

        returnIntent.putExtra("textColour", textColour);
        setResult(Activity.RESULT_OK, returnIntent);

        finish();
    }
}
