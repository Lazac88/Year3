package bit.tuckmn1.topartists;

/**
 * Created by mattt on 12/04/2017.
 */

public class Track
{
    private String trackName;
    private int listenerCount;
    private String artistName;
    private String imageURL;
    private int id;

    public Track(String trackName, int listenerCount, String artistName, String imageURL, int id)
    {
        this.trackName = trackName;
        this.listenerCount = listenerCount;
        this.artistName = artistName;
        this.imageURL = imageURL;
        this.id = id;
    }

    //Getters and Setters
    public String getTrackName()
    {
        return trackName;
    }

    public void setTrackName(String trackName)
    {
        this.trackName = trackName;
    }

    public String getArtistName()
    {
        return artistName;
    }

    public void setArtistName(String artistName)
    {
        this.artistName = artistName;
    }

    public String getImageURL()
    {
        return imageURL;
    }

    public void setImageURL(String imageURL)
    {
        this.imageURL = imageURL;
    }

    public int getListenerCount()
    {
        return listenerCount;
    }

    public void setListenerCount(int listenerCount)
    {
        this.listenerCount = listenerCount;
    }

    public int getId()
    {
        return id;
    }

    public void setId(int id)
    {
        this.id = id;
    }
}
