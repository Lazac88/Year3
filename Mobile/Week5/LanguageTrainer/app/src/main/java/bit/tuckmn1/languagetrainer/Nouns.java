package bit.tuckmn1.languagetrainer;

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
    int imgResID;
    Gender wordGender;
    Boolean answerCorrect;

    public Nouns(String englishWord, String germanWord, int imgResID, Gender wordGender)
    {
        this.englishWord = englishWord;
        this. germanWord = germanWord;
        this.imgResID = imgResID;
        this.wordGender = wordGender;
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

    public int getImgResID()
    {
        return imgResID;
    }

    public Gender getWordGender()
    {
        return wordGender;
    }

}
