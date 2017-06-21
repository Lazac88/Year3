package bit.tuckmn1.topartists;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/**
 * Created by mattt on 12/04/2017.
 */

public class JSONProcessor
{

    public JSONProcessor()
    {

    }

    public JSONObject getJSONObjectFromJSONObject(JSONObject jsonObject, String objectKey)
    {
        JSONObject newJsonObject = null;
        try
        {
            newJsonObject = jsonObject.getJSONObject(objectKey);
        }
        catch (JSONException e)
        {
            e.printStackTrace();
        }
        return newJsonObject;
    }

    public JSONArray getJSONArrayFromJSONObject(JSONObject object, String objectKey)
    {
        //Make string into JSON object
        JSONArray newArray = null;
        try
        {
            newArray = object.getJSONArray(objectKey);
        }
        catch (JSONException e)
        {
            e.printStackTrace();
        }
        return  newArray;
    }

    public JSONObject getJSONObjectFromString(String jsonString)
    {
        //Make string into JSON object
        JSONObject object = null;
        try
        {
            object = new JSONObject(jsonString);
        }
        catch (JSONException e)
        {
            e.printStackTrace();
        }
        return  object;
    }
}
