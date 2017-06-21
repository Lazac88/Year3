package bit.tuckmn1.attractionfinder2;


import android.app.Fragment;
import android.content.Context;
import android.content.res.Resources;
import android.graphics.Bitmap;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.support.v4.content.ContextCompat;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.List;


/**
 * A simple {@link Fragment} subclass.
 */
public class PlacesListFragment extends Fragment
{
    private ListView placesList;
    private int selectedListPosition;

    private MainActivity activity;

    public PlacesListFragment() {
        // Required empty public constructor
    }


    List<Place> listData;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View view = inflater.inflate(R.layout.fragment_places_list, container, false);

        placesList = (ListView) view.findViewById(R.id.placesList);

        activity = (MainActivity) getActivity();
        listData = activity.getMyData();
        selectedListPosition = activity.getSelectedListItem();

        CustomListAdapter listAdapter = new CustomListAdapter(activity, R.layout.places_list_layout, listData);

        placesList.setAdapter(listAdapter);
        placesList.setOnItemClickListener(new onListClickEventHandler());
        placesList.setSelection(selectedListPosition);

        return view;
    }

    public class onListClickEventHandler implements AdapterView.OnItemClickListener
    {
        @Override
        public void onItemClick(AdapterView<?> parent, View view, int position, long id)
        {
            activity.setSelectedListItem(position);
            Place p = listData.get((int)id);
            //Toast.makeText(getActivity(), p.Name, Toast.LENGTH_SHORT).show();
            MainActivity activity = (MainActivity) getActivity();
            activity.LaunchDetailsFragment(p);
        }
    }

    public class CustomListAdapter extends ArrayAdapter<Place>
    {
        public CustomListAdapter(Context context, int resource, List<Place> places)
        {
            super(context, resource, places);
        }

        @Override
        public View getView(int position, View convertView, ViewGroup parent)
        {
            //Grab layout inflater
            LayoutInflater inflater = LayoutInflater.from(getActivity());

            //Create a view using your custom layout file
            View customView = inflater.inflate(R.layout.places_list_layout, parent, false);

            ImageView ivPlacePic = (ImageView) customView.findViewById(R.id.ivImage);
            TextView tvPlaceName = (TextView) customView.findViewById(R.id.tvPlace);

            //Get Current Place
            Place myPlace = getItem(position);

            //Set Text
            String placeName = myPlace.Name;
            tvPlaceName.setText(placeName);

            Resources resourceMachine = getResources();

            //Get Image from API call
            Bitmap myPlaceImage = myPlace.getPlaceImage();
            if(myPlaceImage != null)
            {
                ivPlacePic.setImageBitmap(myPlaceImage);
            }
            else
            {
                Drawable duckPic = ContextCompat.getDrawable(getActivity(), R.drawable.rubber_duck);
                ivPlacePic.setImageDrawable(duckPic);
            }

            //Return the view
            return customView;
        }
    }
}
