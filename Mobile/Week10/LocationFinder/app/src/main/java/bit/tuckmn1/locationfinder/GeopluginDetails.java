package bit.tuckmn1.locationfinder;

/**
 * Created by mattt on 7/05/2017.
 */

public class GeopluginDetails
{
    double Lat;
    double Lng;
    String url;

    public GeopluginDetails(double lat, double lng, String url)
    {
        Lat = lat;
        Lng = lng;
        this.url = url;
    }

    public double getLat()
    {
        return Lat;
    }

    public double getLng()
    {
        return Lng;
    }

    public String getUrl()
    {
        return url;
    }
}
