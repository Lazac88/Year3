package bit.tuckmn1.dialogfragmentplay;

import android.app.AlertDialog;
import android.app.Dialog;
import android.app.DialogFragment;
import android.content.Context;
import android.content.DialogInterface;
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
    public Dialog onCreateDialog(Bundle savedInstanceState)
    {
        MainActivity myActivity = (MainActivity) getActivity();
       // Context context = myActivity.getBaseContext();
        AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder (myActivity);

        // set title
        alertDialogBuilder.setTitle("Order");

        // set dialog message
        alertDialogBuilder.setMessage("Confirm Order");
        //give user the option to cancel the alert dialog
        alertDialogBuilder.setCancelable(false);
        alertDialogBuilder.setPositiveButton("Yes", new YesButtonHandler());
        alertDialogBuilder.setNegativeButton("No", new NoButtonHandler());

        // create alert dialog
        AlertDialog alertDialog = alertDialogBuilder.create();

        // show it
        //alertDialog.show();
        return alertDialog;
    }

    public class YesButtonHandler implements DialogInterface.OnClickListener
    {
        @Override
        public void onClick(DialogInterface dialog, int which)
        {
            MainActivity myActivity = (MainActivity) getActivity();
            myActivity.getConfirmData(true);
        }
    }

    public class NoButtonHandler implements DialogInterface.OnClickListener
    {
        @Override
        public void onClick(DialogInterface dialog, int which)
        {
            MainActivity myActivity = (MainActivity) getActivity();
            myActivity.getConfirmData(false);
        }
    }
}
