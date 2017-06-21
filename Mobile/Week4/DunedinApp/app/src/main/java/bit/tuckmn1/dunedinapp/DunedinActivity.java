package bit.tuckmn1.dunedinapp;

import android.graphics.drawable.Drawable;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ImageView;
import android.widget.TextView;

public class DunedinActivity extends AppCompatActivity
{

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_home_page);

        TextView title = (TextView) findViewById(R.id.homeTitle);
        title.setText(R.string.DunedinActivities);

        ImageView myImage = (ImageView) findViewById(R.id.imageHome);
        Drawable newImage = getResources().getDrawable(R.drawable.dunedin_activities);
        myImage.setImageDrawable(newImage);
    }
}
