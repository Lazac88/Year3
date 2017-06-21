package bit.tuckmn1.welcometodunedin2;


import android.content.Context;
import android.os.Bundle;
import android.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;


/**
 * A simple {@link Fragment} subclass.
 */
public class ImageFragment extends Fragment {


    public ImageFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View myFragment = inflater.inflate(R.layout.fragment_image, container, false);

        MainActivity myActivity = (MainActivity) getActivity();
        String currentSelection = myActivity.getChoosenThing();
        String lowerCaseSelection = currentSelection.toLowerCase();


        TextView imageTitle = (TextView) myFragment.findViewById(R.id.imageFragementTitle);
        imageTitle.setText("Dunedin " + currentSelection);

        ImageView myImage = (ImageView) myFragment.findViewById(R.id.imageViewDisplay);

        Context context = myActivity.getBaseContext();
        int resourceId = context.getResources().getIdentifier(lowerCaseSelection, "drawable", context.getPackageName());
        //context.getResources().getDrawable(resourceId);
        myImage.setImageResource(resourceId);

        return myFragment;
    }

}
