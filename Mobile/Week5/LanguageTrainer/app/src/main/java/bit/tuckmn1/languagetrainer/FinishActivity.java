package bit.tuckmn1.languagetrainer;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.util.ArrayList;

public class FinishActivity extends AppCompatActivity
{
    ArrayList<Nouns> myNouns;
    TextView scoreText;
    Button startTrainingBtn;

    int numCorrect;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_finish);

        Log.d("Just After Change", "");

        Intent results = getIntent();
        numCorrect = results.getIntExtra("numCorrect", 0);

        scoreText = (TextView) findViewById(R.id.textViewScore);
        setResults();

        startTrainingBtn = (Button) findViewById(R.id.btnPlayAgain);
        startTrainingBtn.setOnClickListener(new startNewTraining());
    }

    private void setResults()
    {
        String myScore = Integer.toString(numCorrect);
        String resultsString = "Score: " + myScore + "/11";
        scoreText.setText(resultsString);
    }

    public class startNewTraining implements View.OnClickListener
    {
        @Override
        public void onClick(View view)
        {
            Intent startAgain = new Intent(FinishActivity.this, QuestionActivity.class);
            startActivity(startAgain);
        }
    }
}
