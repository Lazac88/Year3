package bit.tuckmn1.attractionfinder;

import android.os.Parcel;
import android.os.Parcelable;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;

/**
 * Created by mattt on 27/05/2017.
 * Holds all Place data
 */

public class PlaceDbSet implements Parcelable
{
    private List<Place> placeListAttraction;
    private List<Place> placeListDining;
    private List<Place> placeListAccommodation;

    public PlaceDbSet()
    {
        //Required
        placeListAttraction = new ArrayList<Place>();
        placeListDining = new ArrayList<Place>();
        placeListAccommodation = new ArrayList<Place>();

    }

    //Required to make class Parcelable
    public PlaceDbSet(Parcel input)
    {
        placeListAttraction = new ArrayList<Place>();
        placeListDining = new ArrayList<Place>();
        placeListAccommodation = new ArrayList<Place>();
        input.readTypedList(placeListAttraction, Place.CREATOR);
        input.readTypedList(placeListDining, Place.CREATOR);
        input.readTypedList(placeListAccommodation, Place.CREATOR);
    }

    public void OrderData()
    {
        Collections.sort(placeListAttraction, new CustomComparator());
        Collections.sort(placeListAccommodation, new CustomComparator());
        Collections.sort(placeListDining, new CustomComparator());
    }

    public List<Place> getPlaceListAttraction()
    {
        return placeListAttraction;
    }

    public void setPlaceListAttraction(List<Place> placeList)
    {
        this.placeListAttraction = placeList;
    }

    public List<Place> getPlaceListDining()
    {
        return placeListDining;
    }

    public void setPlaceListDining(List<Place> placeListDining)
    {
        this.placeListDining = placeListDining;
    }

    public List<Place> getPlaceListAccommodation()
    {
        return placeListAccommodation;
    }

    public void setPlaceListAccommodation(List<Place> placeListAccommodation)
    {
        this.placeListAccommodation = placeListAccommodation;
    }

    //Following required to make class Parcelable
    @Override
    public int describeContents()
    {
        return 0;
    }

    @Override
    public void writeToParcel(Parcel dest, int flags)
    {
        dest.writeTypedList(placeListAttraction);
        dest.writeTypedList(placeListDining);
        dest.writeTypedList(placeListAccommodation);
    }

    public static final Creator<PlaceDbSet> CREATOR = new Creator<PlaceDbSet>()
    {
        public PlaceDbSet createFromParcel(Parcel in)
        {
            return new PlaceDbSet(in);
        }

        public PlaceDbSet[] newArray(int size)
        {
            return new PlaceDbSet[size];
        }
    };

    public class CustomComparator implements Comparator<Place>
    {
        @Override
        public int compare(Place o1, Place o2)
        {
            return o1.getName().compareTo(o2.getName());
        }
    }
}