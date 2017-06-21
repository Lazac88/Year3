package bit.tuckmn1.kennelclub;


import android.app.FragmentManager;
import android.app.FragmentTransaction;
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
import android.widget.Toast;


/**
 * A simple {@link Fragment} subclass.
 */
public class BreedFragment extends Fragment
{


    public BreedFragment()
    {
        // Required empty public constructor
    }

    private String[] dogBreeds;
    private ImageView breedImage;
    private ListView listDogBreeds;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState)
    {
        // Inflate the layout for this fragment
        View breedView = inflater.inflate(R.layout.fragment_breed, container, false);

        //Do fragment work here
        listDogBreeds = (ListView) breedView.findViewById(R.id.breedListView);
        breedImage = (ImageView) breedView.findViewById(R.id.breedImageView);

        //Draw image
        Resources resourceMachine = getResources();
        Drawable breedTitleImage = resourceMachine.getDrawable(R.drawable.breedinformation, null);
        breedImage.setImageDrawable(breedTitleImage);

        //set up the list
        setUpList();

        //make list clickable
        listDogBreeds.setOnItemClickListener(new listClickHandler());

        return breedView;
    }

    public void setUpList()
    {
        //A java array of Dunedin Activities
        dogBreeds = new String[] {"Sporting", "Hound", "Working", "Terrier", " Toy", "Non-Sporting", "Herding"};
        ArrayAdapter<String> dogBreedAdapter = new ArrayAdapter<String>(getActivity(), android.R.layout.simple_list_item_1, dogBreeds);

        listDogBreeds.setAdapter(dogBreedAdapter);
    }

    public class listClickHandler implements AdapterView.OnItemClickListener
    {
        @Override
        public void onItemClick(AdapterView<?> parent, View view, int position, long id)
        {
            String clickedItemString = (String) parent.getItemAtPosition(position).toString();
            MainActivity myActivity = (MainActivity) getActivity();
            Toast.makeText(getActivity(), clickedItemString, Toast.LENGTH_SHORT).show();
            myActivity.setChoosenBreed(clickedItemString);
            myActivity.launchNewFragment();
        }
    }
}
