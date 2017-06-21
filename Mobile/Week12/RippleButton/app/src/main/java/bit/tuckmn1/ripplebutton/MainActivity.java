package bit.tuckmn1.ripplebutton;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;

import com.skyfishjy.library.RippleBackground;

public class MainActivity extends AppCompatActivity {

    private ImageView hypnosis;
    private RippleBackground rippleBackground;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        rippleBackground = (RippleBackground) findViewById(R.id.content);
        hypnosis = (ImageView) findViewById(R.id.centerImage);

        hypnosis.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v)
            {
                if(!rippleBackground.isRippleAnimationRunning())
                {
                    rippleBackground.startRippleAnimation();
                }
                else
                {
                    rippleBackground.stopRippleAnimation();
                }

            }
        });
    }
}
