package bit.tuckmn1.datapassing;

import android.app.Activity;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class SettingsActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_settings);

        Button myButton = (Button) findViewById(R.id.btnReturnMain);
        myButton.setOnClickListener(new changeActivityBackHandler());
    }


    public class changeActivityBackHandler implements View.OnClickListener
    {

        @Override
        public void onClick(View v)
        {
            Intent returnIntent;

            returnIntent = new Intent(SettingsActivity.this, MainActivity.class);

            EditText id = (EditText) findViewById(R.id.userNameInput);
            String username = id.getText().toString();

            returnIntent.putExtra("username", username);
            setResult(Activity.RESULT_OK, returnIntent);

            finish();
        }
    }
}
