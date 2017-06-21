package bit.tuckmn1.complexcontrols;

import android.content.Intent;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

public class SplashScreen extends AppCompatActivity
{

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_splash_screen);


        Handler myHandler = new Handler();
        Runnable launcher = new LaunchFromSplash();

        myHandler.postDelayed(launcher, 5000);
    }

    public class LaunchFromSplash implements  Runnable
    {
        @Override
        public void run()
        {
            Intent intent = new Intent(SplashScreen.this, MainActivity.class);
            startActivity(intent);
            finish();
        }
    }

    /*myHandler.postDelayed(new Runnable() {
    @Override
    public void run()
    {
        Intent changeActivity = new Intent(SplashScreen.this, MainActivity.class);
        startActivity(changeActivity);
    }
}, 8000);*/
}
