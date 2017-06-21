package bit.tuckmn1.attractionfinder2;

import java.util.ArrayList;

/**
 * Created by mattt on 29/05/2017.
 */

public class PlacesListStringResults
{

    private ArrayList<String> attractionJSONStringList;
    private ArrayList<String> diningJSONStringList;
    private ArrayList<String> accommodationJSONStringList;

    public PlacesListStringResults()
    {
        attractionJSONStringList = new ArrayList<String>();
        diningJSONStringList = new ArrayList<String>();
        accommodationJSONStringList = new ArrayList<String>();
    }

    public void addAttractionJsonString(String JSON)
    {
        attractionJSONStringList.add(JSON);
    }

    public void addDiningJsonString(String JSON)
    {
        diningJSONStringList.add(JSON);
    }

    public void addAccommodationJsonString(String JSON)
    {
        accommodationJSONStringList.add(JSON);
    }

    public ArrayList<String> getAttractionJSONStringList()
    {
        return attractionJSONStringList;
    }

    public ArrayList<String> getDiningJSONStringList()
    {
        return diningJSONStringList;
    }

    public ArrayList<String> getAccommodationJSONStringList()
    {
        return accommodationJSONStringList;
    }
}
