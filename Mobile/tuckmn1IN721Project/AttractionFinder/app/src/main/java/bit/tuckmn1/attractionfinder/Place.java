package bit.tuckmn1.attractionfinder;

import android.graphics.Bitmap;
import android.os.Parcel;
import android.os.Parcelable;

import java.util.List;

/**
 * Created by mattt on 27/05/2017.
 * Holds all required information about a place
 */

public class Place implements Parcelable
{
    public String id;
    public String Name;
    public String Address;
    public double Latitude;
    public double Longitude;
    public String PhotoReference;
    public List<String> PlaceTypes;
    public Bitmap PlaceImage;

    public Place(String id, String name, String address, double latitude, double longitude, String photoReference, List<String> placeTypes)
    {
        this.id = id;
        Name = name;
        Address = address;
        Latitude = latitude;
        Longitude = longitude;
        PhotoReference = photoReference;
        PlaceTypes = placeTypes;
        PlaceImage = null;
    }

    //Needed to make class Parcelable
    public Place(Parcel input)
    {
        id = input.readString();
        Name = input.readString();
        Address = input.readString();
        Latitude = input.readDouble();
        Longitude = input.readDouble();
        PhotoReference = input.readString();
        PlaceTypes = input.createStringArrayList();
        PlaceImage = (Bitmap) input.readParcelable(getClass().getClassLoader());
    }

    public String getId()
    {
        return id;
    }

    public String getName()
    {
        return Name;
    }

    public String getAddress()
    {
        return Address;
    }

    public double getLatitude()
    {
        return Latitude;
    }

    public double getLongitude()
    {
        return Longitude;
    }

    public String getPhotoReference()
    {
        return PhotoReference;
    }

    public List<String> getPlaceTypes()
    {
        return PlaceTypes;
    }

    public Bitmap getPlaceImage()
    {
        return PlaceImage;
    }

    public void setPlaceImage(Bitmap placeImage)
    {
        PlaceImage = placeImage;
    }

    @Override
    public int describeContents()
    {
        return 0;
    }


    //Needed to make class Parcelable
    @Override
    public void writeToParcel(Parcel dest, int flags)
    {
        dest.writeString(id);
        dest.writeString(Name);
        dest.writeString(Address);
        dest.writeDouble(Latitude);
        dest.writeDouble(Longitude);
        dest.writeString(PhotoReference);
        dest.writeStringList(PlaceTypes);
        dest.writeParcelable(PlaceImage, flags);
    }

    public static final Creator<Place> CREATOR = new Creator<Place>()
    {
        public Place createFromParcel(Parcel in)
        {
            return new Place(in);
        }

        public Place[] newArray(int size)
        {
            return new Place[size];
        }
    };
}
