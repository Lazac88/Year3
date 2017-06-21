package bit.tuckmn1.welcometodunedin2;


import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.content.Intent;
import android.os.Bundle;
import android.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Adapter;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;


/**
 * A simple {@link Fragment} subclass.
 */
public class ListFragment extends Fragment {


    public ListFragment() {
        // Required empty public constructor
    }

    ListView dunedinThings;


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View myFragment = inflater.inflate(R.layout.fragment_list, container, false);

        dunedinThings = (ListView) myFragment.findViewById(R.id.dunedinList);
        dunedinThings.setOnItemClickListener(new listClickHandler());
        setUpList();

        return myFragment;
    }

    public void setUpList()
    {
        //A java array of Dunedin Activities
        String[] thingsToDo = new String[] { "Activities", "Shopping", "Dining", "Services" };
        ArrayAdapter<String> dunedinThingsAdapter = new ArrayAdapter<String>(getActivity(), R.layout.drawer_list_layout, thingsToDo);

        dunedinThings.setAdapter(dunedinThingsAdapter);
    }

    public class listClickHandler implements AdapterView.OnItemClickListener
    {

        @Override
        public void onItemClick(AdapterView<?> parent, View view, int position, long id)
        {
            String clickedItemString = (String) parent.getItemAtPosition(position).toString();

            Fragment dynamicFragment = new ImageFragment();
            FragmentManager fm = getFragmentManager();
            FragmentTransaction ft = fm.beginTransaction();

            MainActivity myActivity = (MainActivity) getActivity();
            myActivity.setChoosenThing(clickedItemString);

            ft.replace(R.id.imageFragmentPlaceholder, dynamicFragment);
            ft.commit();
        }
    }

}
