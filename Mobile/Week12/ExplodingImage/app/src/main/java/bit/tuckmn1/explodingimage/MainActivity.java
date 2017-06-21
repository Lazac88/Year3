package bit.tuckmn1.explodingimage;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;

import com.easyandroidanimations.library.ExplodeAnimation;

public class MainActivity extends AppCompatActivity {

    ImageView bomb;
    ExplodeAnimation explodeAnimation;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        bomb = (ImageView) findViewById(R.id.bomb);
        explodeAnimation = new ExplodeAnimation(bomb);

        bomb.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                
                explodeAnimation.animate();
            }
        });


    }
}
