package bit.tuckmn1.languagetrainer;

import android.content.Intent;
import android.graphics.Color;
import android.graphics.drawable.Drawable;
import android.nfc.Tag;
import android.support.v4.content.res.ResourcesCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Random;

public class QuestionActivity extends AppCompatActivity
{
    private static final String TAG = "QuestionActivity";

    private ArrayList<Nouns> myNouns;
    private final int  NUM_QUESTIONS = 11;
    private Random rand;
    private int questionNumber;
    private Boolean onQuestion;

    //All display elements
    TextView questionTextView;
    TextView answerTextView;
    Button submitButton;
    ImageView nounPicture;
    RadioGroup radioChoices;
    RadioButton checkedRadio;
    RadioButton radioBtn1;
    RadioButton radioBtn2;
    RadioButton radioBtn3;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_question);

        rand = new Random();
        myNouns = createNouns();
        shuffleNouns();

        onQuestion = true;

        questionNumber = 0;
        questionTextView = (TextView) findViewById(R.id.questionNumberTextView);
        answerTextView = (TextView) findViewById(R.id.answerTextView);
        nounPicture = (ImageView) findViewById(R.id.imgNoun);
        radioChoices = (RadioGroup) findViewById(R.id.radioGroup);

        radioBtn1 = (RadioButton) findViewById(R.id.Das);
        radioBtn2 = (RadioButton) findViewById(R.id.Der);
        radioBtn3 = (RadioButton) findViewById(R.id.Die);

        submitButton = (Button) findViewById(R.id.btnSubmit);
        submitButton.setOnClickListener(new submitButtonHandler());

        //Set Up First Question
        setQuestion();
        setImage();
    }

    private ArrayList<Nouns> createNouns()
    {
        ArrayList<Nouns> myList = new ArrayList<Nouns>();
        int drawableID = R.drawable.apple;
        Nouns apple = new Nouns("Apple", "Apfel", drawableID, Gender.Der);
        drawableID = R.drawable.car;
        Nouns car = new Nouns("Car", "Auto", drawableID, Gender.Das);
        drawableID = R.drawable.tree;
        Nouns tree = new Nouns("Tree", "Baum", drawableID, Gender.Der);
        drawableID = R.drawable.duck;
        Nouns duck = new Nouns("Duck", "Ente", drawableID, Gender.Die);
        drawableID = R.drawable.house;
        Nouns house = new Nouns("House", "Haus", drawableID, Gender.Das);
        drawableID = R.drawable.witch;
        Nouns witch = new Nouns("Witch", "Hexe", drawableID, Gender.Die);
        drawableID = R.drawable.cow;
        Nouns cow = new Nouns("Cow", "Kuh", drawableID, Gender.Die);
        drawableID = R.drawable.milk;
        Nouns milk = new Nouns("Milk", "Milch", drawableID, Gender.Die);
        drawableID = R.drawable.sheep;
        Nouns sheep = new Nouns("Sheep", "Schaf", drawableID, Gender.Das);
        drawableID = R.drawable.street;
        Nouns street = new Nouns("Street", "Strasse", drawableID, Gender.Die);
        drawableID = R.drawable.chair;
        Nouns chair = new Nouns("Chair", "Stuhl", drawableID, Gender.Der);
        myList.add(apple);
        myList.add(car);
        myList.add(tree);
        myList.add(duck);
        myList.add(house);
        myList.add(witch);
        myList.add(cow);
        myList.add(milk);
        myList.add(sheep);
        myList.add(street);
        myList.add(chair);
        return myList;
    }

    private void shuffleNouns()
    {
        Collections.shuffle(myNouns);
        //int shuffleNumber = NUM_QUESTIONS * 7;
        //for(int i = 0; i < shuffleNumber; i++)
        {
            //int x = rand.nextInt(NUM_QUESTIONS);
            //int y = rand.nextInt(NUM_QUESTIONS);
           // swapPosition(x, y);
        }
    }

    private void swapPosition(int x, int y)
    {
        Nouns temp = myNouns.get(x);
        myNouns.add(x, myNouns.get(y));
        myNouns.add(y, temp);
    }

    public void setQuestion()
    {
        int qNumber = questionNumber + 1;
        questionTextView.setText("Question " + qNumber);
    }

    public void setImage()
    {
        int drawableId = myNouns.get(questionNumber).getImgResID();
        String drawID =  Integer.toString(drawableId);
        Log.d("setImageQNumber", Integer.toString(questionNumber));
        Log.d("setImage", drawID);
        Drawable newImage = getResources().getDrawable(drawableId);
        nounPicture.setImageDrawable(newImage);
    }

    public Boolean checkChoiceMade()
    {
        if(radioBtn1.isChecked() || radioBtn2.isChecked() || radioBtn3.isChecked())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private int getCorrect()
    {
        int numScore = 0;
        for(Nouns noun : myNouns)
        {
            if(noun.getAnswerCorrect())
            {
                numScore++;
            }
        }
        return numScore;
    }

    public class submitButtonHandler implements View.OnClickListener
    {

        @Override
        public void onClick(View view)
        {
            if(checkChoiceMade())
            {
                if(questionNumber < 11)
                {
                    if(onQuestion)      //onQuestion used to determine if the user is looking at answer or question
                    {
                        //Find what radio button the user selected
                        int radioBtnID = radioChoices.getCheckedRadioButtonId();
                        checkedRadio = (RadioButton) findViewById(radioBtnID);
                        String radioText = checkedRadio.getText().toString().trim();

                        //Disable Radio Buttons
                        radioBtn1.setEnabled(false);
                        radioBtn2.setEnabled(false);
                        radioBtn3.setEnabled(false);

                        //Find the answer to the current question and check if it matches answer
                        Gender answer = myNouns.get(questionNumber).getWordGender();
                        String sAnswer = answer.toString().trim();
                        Log.d(TAG, sAnswer);
                        Log.d(TAG, radioText);
                        if(sAnswer.contentEquals(radioText))
                        {
                            answerTextView.setText(R.string.answer_correct);

                            int incorrectColour = ResourcesCompat.getColor(getResources(), R.color.corrrectColour, null);
                            answerTextView.setTextColor(incorrectColour);

                            myNouns.get(questionNumber).setAnswerCorrect(true);
                        }
                        else
                        {
                            answerTextView.setText(R.string.answer_incorrect);

                            int incorrectColour = ResourcesCompat.getColor(getResources(), R.color.incorrectColour, null);
                            answerTextView.setTextColor(incorrectColour);
                        }


                        submitButton.setText("Continue");
                        onQuestion = false;
                    }
                    else        //When they are on answer screen
                    {
                        onQuestion = true;
                        questionNumber++;
                        answerTextView.setText("");
                        if(questionNumber < 11)
                        {
                            //Enable Radio Buttons
                            RadioButton radioBtn1 = (RadioButton) findViewById(R.id.Das);
                            RadioButton radioBtn2 = (RadioButton) findViewById(R.id.Der);
                            RadioButton radioBtn3 = (RadioButton) findViewById(R.id.Die);
                            radioBtn1.setEnabled(true);
                            radioBtn2.setEnabled(true);
                            radioBtn3.setEnabled(true);

                            setQuestion();
                            setImage();
                            submitButton.setText("Check Answer");
                            radioChoices.clearCheck();
                        }
                        else
                        {
                            submitButton.setText("Continue To Results");
                        }
                    }
                }
                else
                {
                    //Create Intent and Send nounList through to final activity
                    Intent changeToFinishActivity;

                    //Bundle extra = new Bundle();
                    //extra.putSerializable("nouns", myNouns);
                    int numCorrect = getCorrect();
                    changeToFinishActivity = new Intent(QuestionActivity.this, FinishActivity.class);
                    changeToFinishActivity.putExtra("numCorrect", numCorrect);
                    Log.d("Just b4 activity change", "");
                    startActivity(changeToFinishActivity);
                }
            }//End checkChoiceMade
        }//End onClick
    }//End Submit button handler class
}
