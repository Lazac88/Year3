package bit.tuckmn1.languagetrainer;

import android.content.Context;
import android.content.Intent;
import android.content.res.Resources;
import android.graphics.drawable.Drawable;
import android.support.annotation.LayoutRes;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;

import com.google.gson.Gson;

import java.util.ArrayList;
import java.util.List;

public class FinishActivity extends AppCompatActivity
{
    private final int NUM_QUESTIONS = 11;
    private ArrayList<Nouns> myNouns;
    private TextView scoreText;
    private Button startTrainingBtn;

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

        //Grab each entry as json, covert back to noun instance and add to list
        myNouns = new ArrayList<Nouns>();
        Gson gson = new Gson();
        for(int i = 0; i < NUM_QUESTIONS; i++)
        {
            String marker = Integer.toString(i);
            String returnJson = results.getStringExtra(marker);
            Nouns noun = gson.fromJson(returnJson, Nouns.class);
            myNouns.add(noun);
        }

        ListView resultsListView = (ListView) findViewById(R.id.resultsListView);
        BetterArrayAdapter resultsListAdapter = new BetterArrayAdapter(FinishActivity.this, R.layout.results_list_layout, myNouns);
        resultsListView.setAdapter(resultsListAdapter);

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

    public class BetterArrayAdapter extends ArrayAdapter<Nouns>
    {

        public BetterArrayAdapter(Context context, int resource, List<Nouns> objects)
        {
            super(context, resource, objects);
        }

        @Override
        public View getView(int position, View convertView, ViewGroup parent)
        {
            LayoutInflater inflater = LayoutInflater.from(FinishActivity.this);

            View customView = inflater.inflate(R.layout.results_list_layout, parent, false);

            ImageView ivItem = (ImageView) customView.findViewById(R.id.imageViewItem);
            ImageView ivRightWrong = (ImageView) customView.findViewById(R.id.imageViewRightWrong);
            TextView yourAnswer = (TextView) customView.findViewById(R.id.textViewNoun);

            //Get current Item
            Nouns myNoun = getItem(position);

            //Add noun picture
            Resources resourceMachine = getResources();
            //int resID = myNoun.getImgResID();

            String nounName = myNoun.getEnglishWord().trim().toLowerCase();
            int resourceId = resourceMachine.getIdentifier(nounName, "drawable", FinishActivity.this.getPackageName());
            Drawable nounPic = resourceMachine.getDrawable(resourceId, null);

            ivItem.setImageDrawable(nounPic);

            //Add noun text
            String result = "You Answered: " + myNoun.getUserAnswer();
            yourAnswer.setText(result);

            //Add confirmation picture
            boolean userCorrect = myNoun.getAnswerCorrect();
            if(userCorrect)
            {
                Drawable tick = resourceMachine.getDrawable(R.drawable.tick, null);
                ivRightWrong.setImageDrawable(tick);
            }
            else
            {
                Drawable cross = resourceMachine.getDrawable(R.drawable.cross, null);
                ivRightWrong.setImageDrawable(cross);
            }

            //return the view
            return customView;
        }
    }
}
