package bit.tuckmn1.datapassing;

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

        Button btnSettings = (Button) findViewById(R.id.btnSettings);
        btnSettings.setOnClickListener(new changeActivityHandler());
    }




    public class changeActivityHandler implements View.OnClickListener
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
            String username = data.getStringExtra("username");
            TextView myUser = (TextView) findViewById(R.id.userName);
            myUser.setText(username);
        }
    }
}
