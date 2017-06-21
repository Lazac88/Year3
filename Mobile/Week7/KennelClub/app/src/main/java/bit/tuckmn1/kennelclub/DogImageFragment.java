package bit.tuckmn1.kennelclub;


import android.content.res.Resources;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.app.DialogFragment;
import android.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;


/**
 * A simple {@link Fragment} subclass.
 */
public class DogImageFragment extends DialogFragment
{


    public DogImageFragment()
    {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState)
    {
        // Inflate the layout for this fragment
        View dialogViewImage = inflater.inflate(R.layout.iv_layout_dialogbuilder, container, false);

        ImageView myImage = (ImageView) dialogViewImage.findViewById(R.id.dogDialogImage);

        int resourceID = getArguments().getInt("resId");

        //Draw image
        Resources resourceMachine = getResources();
        Drawable dogDialogBox = resourceMachine.getDrawable(resourceID, null);

        myImage.setImageDrawable(dogDialogBox);

        //return the view
        return dialogViewImage;
    }

}
