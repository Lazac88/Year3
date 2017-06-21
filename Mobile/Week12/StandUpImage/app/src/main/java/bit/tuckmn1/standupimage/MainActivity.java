package bit.tuckmn1.standupimage;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;

import com.daimajia.androidanimations.library.Techniques;
import com.daimajia.androidanimations.library.YoYo;

public class MainActivity extends AppCompatActivity {

    ImageView gary;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        gary = (ImageView) findViewById(R.id.gary);

        gary.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v)
            {
                YoYo.with(Techniques.StandUp)
                        .duration(700)
                        .repeat(5)
                        .playOn(gary);
            }
        });

    }
}
