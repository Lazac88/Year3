package bit.tuckmn1.kennelclub;


import android.app.FragmentManager;
import android.content.Context;
import android.content.res.Resources;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import org.w3c.dom.Text;

import java.util.ArrayList;


/**
 * A simple {@link Fragment} subclass.
 */
public class DogListFragment extends Fragment
{


    public DogListFragment()
    {
        // Required empty public constructor
    }

    private ArrayList<Dog> dogList;
    ListView allDogList;
    TextView titleDogBreed;
    DogImageFragment pictureFragment;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState)
    {
        // Inflate the layout for this fragment
        View dogListView = inflater.inflate(R.layout.fragment_dog_list, container, false);

        //Get an instance of main activty and grab list of dog
        MainActivity mainActivity = (MainActivity) getActivity();
        dogList = mainActivity.getDogList();

        //Create the ListBox custom Adapter
        ImageListArrayAdapter dogBreedAdapter = new ImageListArrayAdapter(getActivity(), R.layout.image_listview_layout, dogList);

        //Grab the components
        allDogList = (ListView) dogListView.findViewById(R.id.dogTypes);
        titleDogBreed = (TextView) dogListView.findViewById((R.id.dogTypeTextTitle));

        //Add adapter to listview
        allDogList.setAdapter(dogBreedAdapter);

        //Change the title
        titleDogBreed.setText(mainActivity.getBreedString());

        //Add Item click listener to ListView
        allDogList.setOnItemClickListener(new onListClickHandler());

        return dogListView;
    }

    public class onListClickHandler implements AdapterView.OnItemClickListener
    {

        @Override
        public void onItemClick(AdapterView<?> parent, View view, int position, long id)
        {
            String clickedItemString = (String) parent.getItemAtPosition(position).toString().toLowerCase();
            Toast.makeText(getActivity(), clickedItemString, Toast.LENGTH_SHORT).show();

            int resourceId = getActivity().getResources().getIdentifier(clickedItemString, "drawable", getActivity().getPackageName());


            //Create bundle that holds drawable
            Bundle myBundle = new Bundle();
            myBundle.putInt("resId", resourceId);

            FragmentManager fm = getFragmentManager();
            pictureFragment = new DogImageFragment();
            pictureFragment.setArguments(myBundle);
            pictureFragment.show(fm, "imageShow");
        }
    }



    public class ImageListArrayAdapter extends ArrayAdapter<Dog>
    {
        public ImageListArrayAdapter(Context context, int resource, ArrayList<Dog> objects)
        {
            super(context, resource, objects);
        }

        @Override
        public View getView(int position, View convertView, ViewGroup parent)
        {
            MainActivity mainActivity = (MainActivity) getActivity();
            //Get an inflater from the activity
            LayoutInflater inflater = LayoutInflater.from(mainActivity);

            //Inflate our custom view
            View customView = inflater.inflate(R.layout.image_listview_layout, parent, false);

            //Grab references to the controls
            ImageView img = (ImageView) customView.findViewById(R.id.ivItemImage);
            TextView tv = (TextView) customView.findViewById(R.id.tvItemText);

            //Get the current input into the Array Adapter
            Dog currentDog = getItem(position);

            //Use the dog instance to initialise the View controls
            img.setImageDrawable(currentDog.getDogImage());
            tv.setText(currentDog.getName());

            return customView;
        }
    }
}
