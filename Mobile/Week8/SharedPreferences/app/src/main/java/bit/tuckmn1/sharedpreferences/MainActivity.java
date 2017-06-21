package bit.tuckmn1.sharedpreferences;

import android.content.SharedPreferences;
import android.graphics.Color;
import android.support.v4.content.ContextCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    SharedPreferences prefs;
    SharedPreferences.Editor prefsEditor;

    TextView lanText;
    TextView colText;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        prefs = getSharedPreferences("myPrefs", MODE_PRIVATE);
        prefsEditor = prefs.edit();

        lanText = (TextView) findViewById(R.id.appTitle);
        colText = (TextView) findViewById(R.id.appColour);

        String language = prefs.getString("language", null);
        if (language != null)
        {
            updateTextViews(language);
        }

        String colour = prefs.getString("colour", null);
        if(colour != null)
        {
            updateTextColours(colour);
        }

        Button updatePrefsBtn = (Button) findViewById(R.id.btnPrefs);
        updatePrefsBtn.setOnClickListener(new buttonEventHandler());
    }

    private void updateTextViews(String language)
    {
        switch(language)
        {
            case "English":
                lanText.setText("Hello World");
                break;
            case "German":
                lanText.setText("Hallo Welt");
                break;
            case "Spanish":
                lanText.setText("Hola Mundo");
                break;
        }
    }

    private void updateTextColours(String colour)
    {
        int red = ContextCompat.getColor(this, R.color.red);
        int green = ContextCompat.getColor(this, R.color.green);
        int blue = ContextCompat.getColor(this, R.color.blue);

        switch(colour)
        {
            case "Red":
                lanText.setTextColor(red);
                colText.setTextColor(red);
                break;
            case "Green":
                lanText.setTextColor(green);
                colText.setTextColor(green);
                break;
            case "Blue":
                lanText.setTextColor(blue);
                colText.setTextColor(blue);
                break;
        }
    }

    private class buttonEventHandler implements View.OnClickListener
    {

        @Override
        public void onClick(View v)
        {

            //Update Language
            RadioGroup rdoLan = (RadioGroup) findViewById(R.id.languageGroup);
            int checkedRadioId = rdoLan.getCheckedRadioButtonId();
            RadioButton rBtnLan = (RadioButton) findViewById(checkedRadioId);
            String radioValue = rBtnLan.getText().toString();

            prefsEditor.putString("language", radioValue);
            prefsEditor.commit();
            updateTextViews(radioValue);

            //Update Colours
            RadioGroup rdoCol = (RadioGroup) findViewById(R.id.colourGroup);
            int checkedRadioIdCol = rdoCol.getCheckedRadioButtonId();
            RadioButton rBtnCol = (RadioButton) findViewById(checkedRadioIdCol);
            String radioValueCol = rBtnCol.getText().toString();

            prefsEditor.putString("colour", radioValueCol);
            prefsEditor.commit();
            updateTextColours(radioValueCol);
        }
    }
}
