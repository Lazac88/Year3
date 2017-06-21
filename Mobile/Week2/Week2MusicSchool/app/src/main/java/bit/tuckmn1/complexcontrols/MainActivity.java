package bit.tuckmn1.complexcontrols;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Spinner;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //Grabbing the enroll button
        Button enrollButton = (Button) findViewById(R.id.btnEnroll);

        //Creating an instance of the inner class event handler.
        EnrollmentHandler enroll = new EnrollmentHandler();
        //Passing the button the event handler
        enrollButton.setOnClickListener(enroll);

        //A java array of months
        String[] Months = new String[] { "January", "February",
                "March", "April", "May", "June", "July", "August", "September",
                "October", "November", "December" };


        //Grabbing the spinner
        Spinner monthsSpinner = (Spinner) findViewById(R.id.monthsSpinner);

        //Grabbing the ID of an inbuilt layout to pass to the spinner Adapter
        int layoutID = android.R.layout.simple_spinner_item;
        //Creating an instance of an ArrayAdapter. Requires the activity, a layout, and an array
        ArrayAdapter<String> monthsAdapter = new ArrayAdapter<String>(this, layoutID, Months);
        //Passing the ArrayAdapter to the spinner
        monthsSpinner.setAdapter(monthsAdapter);
    }

    //Inner class to hold event handlers
    public class EnrollmentHandler implements View.OnClickListener
    {

        @Override
        public void onClick(View v)
        {
            Boolean noErrors = true;
            String instrumChoice = "";

            //Grabbing the radioGroup
            RadioGroup radioGroup = (RadioGroup) findViewById(R.id.radioGroup);
            //Finding the id of the radiobutton that has been checked.
            int selectedID = radioGroup.getCheckedRadioButtonId();

            //Grabbing the text from the checked radio button if it is checked
            if(selectedID != -1)
            {
                //Creating an pointer to the checked radio button
                RadioButton checkedButton = (RadioButton) findViewById(selectedID);
                instrumChoice = checkedButton.getText().toString();
            }
            else
            {
                noErrors = false;
            }


            //Grabbing the spinner
            Spinner monthsSpinner = (Spinner) findViewById(R.id.monthsSpinner);
            //Finding the selected item. We know our spinner holds Strings so we cast for it
            String myMonth = (String)monthsSpinner.getSelectedItem();

            if(noErrors)
            {
                //Using Toast to display confirmation about enrollment
                Toast enrollMessage = Toast.makeText(MainActivity.this, "You have enrolled in " + instrumChoice + " classes, for the month of " + myMonth, Toast.LENGTH_LONG);
                enrollMessage.show();
            }
            else
            {
                //Using Toast to display error with enrollment
                Toast enrollMessage = Toast.makeText(MainActivity.this, "Please select an instrument to continue with enrollment", Toast.LENGTH_LONG);
                enrollMessage.show();
            }

        }
    }
}
