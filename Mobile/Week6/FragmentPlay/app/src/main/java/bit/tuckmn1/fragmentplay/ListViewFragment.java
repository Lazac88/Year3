package bit.tuckmn1.fragmentplay;


import android.os.Bundle;
import android.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ListView;


/**
 * A simple {@link Fragment} subclass.
 */
public class ListViewFragment extends Fragment
{


    public ListViewFragment()
    {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState)
    {
        // Inflate the layout for this fragment
        View fragmentView = inflater.inflate(R.layout.fragment_list_view, container, false);

        //Use the fragment view to get listview from xml
        ListView lvAnimals = (ListView) fragmentView.findViewById(R.id.listViewAnimals);

        //A java array of Animals
        String[] thingsToDo = new String[] { "Cow", "Sheep", "Duck", "Cat", "Dog" };
        int layoutID = android.R.layout.simple_list_item_1;
        ArrayAdapter<String> animalAdapter = new ArrayAdapter<String>(getActivity(), layoutID, thingsToDo);

        lvAnimals.setAdapter(animalAdapter);

        //Return whole fragment view
        return fragmentView;
    }

}
