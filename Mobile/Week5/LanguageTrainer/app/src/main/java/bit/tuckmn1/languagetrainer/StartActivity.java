package bit.tuckmn1.languagetrainer;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class StartActivity extends AppCompatActivity
{

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_start);

        Button start = (Button) findViewById(R.id.btnStartTrainer);
        start.setOnClickListener(new moveToTrainingActivity());
    }

    public class moveToTrainingActivity implements View.OnClickListener
    {

        @Override
        public void onClick(View view)
        {
            Intent startTrainer;

            startTrainer = new Intent(StartActivity.this, QuestionActivity.class);

            startActivity(startTrainer);
        }
    }
}
