package bit.tuckmn1.locationjumper;

/**
 * Created by mattt on 4/05/2017.
 */

public class LocationDetails
{
    String JSONString;
    String latitude;
    String longitude;

    public LocationDetails(String JSONString, String latitude, String longitude)
    {
        this.JSONString = JSONString;
        this.latitude = latitude;
        this.longitude = longitude;
    }

    public String getJSONString()
    {
        return JSONString;
    }

    public String getLatitude()
    {
        return latitude;
    }

    public String getLongitude()
    {
        return longitude;
    }
}
