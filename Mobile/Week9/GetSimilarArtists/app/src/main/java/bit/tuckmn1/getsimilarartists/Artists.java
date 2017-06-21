package bit.tuckmn1.getsimilarartists;

/**
 * Created by mattt on 13/04/2017.
 */

public class Artists
{
    private String name;
    private String url;

    private String imageURL;
    private int id;

    public Artists(String name, String url, String imageURL, int id)
    {
        this.name = name;
        this.url = url;
        this.imageURL = imageURL;
        this.id = id;
    }

    public String getName()
    {
        return name;
    }

    public String getUrl()
    {
        return url;
    }

    public String getImageURL()
    {
        return imageURL;
    }

    public int getId()
    {
        return id;
    }

}
