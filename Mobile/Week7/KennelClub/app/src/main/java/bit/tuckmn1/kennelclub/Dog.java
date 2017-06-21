package bit.tuckmn1.kennelclub;

import android.graphics.drawable.Drawable;

/**
 * Created by mattt on 1/04/2017.
 */

public class Dog
{
    String name;
    Drawable dogImage;

    public Dog(String name, Drawable dogImage)
    {
        this.name = name;
        this.dogImage = dogImage;
    }

    public String getName()
    {
        return name;
    }

    @Override
    public String toString()
    {
        return name;
    }

    public Drawable getDogImage()
    {
        return dogImage;
    }
}
