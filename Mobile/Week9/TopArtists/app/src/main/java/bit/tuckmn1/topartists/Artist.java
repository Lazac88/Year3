package bit.tuckmn1.topartists;

/**
 * Created by mattt on 14/04/2017.
 */

public class Artist
{
    public String name;
    public int listeners;
    public String imageURl;
    public int id;

    public Artist(String name, int listeners, String imageURl, int id)
    {
        this.name = name;
        this.listeners = listeners;
        this.imageURl = imageURl;
        this.id = id;
    }

    public String getName()
    {
        return name;
    }

    public int getListeners()
    {
        return listeners;
    }

    public String getImageURl()
    {
        return imageURl;
    }

    public int getId()
    {
        return id;
    }
}
