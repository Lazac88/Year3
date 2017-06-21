package bit.tuckmn1.languagetrainer;

import android.content.res.Resources;
import android.graphics.drawable.Drawable;
import android.os.Parcel;
import android.os.Parcelable;

import java.io.Serializable;

/**
 * Created by mattt on 15/03/2017.
 */

public class Nouns
{
    String englishWord;
    String germanWord;

    String userAnswer;

    int imgResID;

    Gender wordGender;
    Boolean answerCorrect;

    public Nouns(String englishWord, String germanWord, int imgResID, Gender wordGender)
    {
        this.englishWord = englishWord;
        this. germanWord = germanWord;
        this.imgResID = imgResID;
        this.wordGender = wordGender;
        userAnswer = "";
        answerCorrect = false;
    }

    public void setAnswerCorrect(Boolean answer)
    {
        answerCorrect = answer;
    }

    public Boolean getAnswerCorrect()
    {
        return answerCorrect;
    }

    public String getEnglishWord()
    {
        return englishWord;
    }

    public String getGermanWord()
    {
        return germanWord;
    }

    public String getUserAnswer() { return userAnswer; }

    public void setUserAnswer(String answered) {userAnswer = answered; }

    public int getImgResID()
    {
        return imgResID;
    }

    public Gender getWordGender()
    {
        return wordGender;
    }

}
