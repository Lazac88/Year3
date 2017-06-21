package bit.tuckmn1.jsonapp;

/**
 * Created by mattt on 7/04/2017.
 */

public class DunedinEvent
{
    private String title;
    private String description;
    private int id;

    public DunedinEvent(String title, String description, int id)
    {
        this.title = title;
        this.description = description;
        this.id = id;
    }

    public String getDescription()
    {
        return description;
    }

    public int getId()
    {
        return id;
    }

    public String getTitle()
    {
        return title;
    }
}
