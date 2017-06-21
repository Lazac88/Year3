package bit.tuckmn1.dialogfragmentplay;

import android.app.Dialog;
import android.app.DialogFragment;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;

/**
 * Created by tuckmn1 on 24/03/2017.
 */

public class PizzaConfirmFragment extends DialogFragment
{
    public PizzaConfirmFragment()
    {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstance)
    {
        //Inflate the layout to produce a view
        View dialogView = inflater.inflate(R.layout.pizza_confirm_layout, container, false);

        Button yesButton = (Button) dialogView.findViewById(R.id.btnConfirm);
        yesButton.setOnClickListener(new YesButtonHandler());

        Button noButton = (Button) dialogView.findViewById(R.id.btnDecline);
        noButton.setOnClickListener(new NoButtonHandler());

        //Return the view
        return dialogView;
    }

    public class YesButtonHandler implements View.OnClickListener
    {

        @Override
        public void onClick(View v)
        {
            MainActivity myActivity = (MainActivity) getActivity();
            myActivity.getConfirmData(true);
        }
    }

    public class NoButtonHandler implements View.OnClickListener
    {

        @Override
        public void onClick(View v)
        {
            MainActivity myActivity = (MainActivity) getActivity();
            myActivity.getConfirmData(false);
        }
    }
}
