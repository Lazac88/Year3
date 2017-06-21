package bit.tuckmn1.barcodereaderinclass;

import android.content.Intent;
import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity
{
    public static final int QR_RETURN_CODE = 1;
    private static final int NUM_MONTHS = 12;

    private int[] months;
    private String[] monthNames;
    private Button readCode;
    private TextView displayInfo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //Create months array and set all values to zero
        months = new int[NUM_MONTHS];
        monthNames = GetMonthsArray();
        for(int i = 0; i < months.length; i++)
        {
            months[i] = 0;
        }
        readCode = (Button) findViewById(R.id.btnReadCode);
        displayInfo = (TextView) findViewById(R.id.codeInfo);

        readCode.setOnClickListener(new OnButtonClickHandler());
    }

    private String[] GetMonthsArray()
    {
        String[] myMonths = new String[NUM_MONTHS];
        myMonths[0] = "Janurary";
        myMonths[1] = "Feburary";
        myMonths[2] = "March";
        myMonths[3] = "April";
        myMonths[4] = "May";
        myMonths[5] = "June";
        myMonths[6] = "July";
        myMonths[7] = "August";
        myMonths[8] = "September";
        myMonths[9] = "October";
        myMonths[10] = "November";
        myMonths[11] = "December";
        return myMonths;
    }

    public class OnButtonClickHandler implements View.OnClickListener
    {
        @Override
        public void onClick(View v)
        {
            Intent intent = new Intent(MainActivity.this, QrReader.class);
            startActivityForResult(intent, QR_RETURN_CODE);

        }
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data)
    {
        boolean monthFound = true;
        // Check which request we're responding to
        if (requestCode == QR_RETURN_CODE)
        {
            // Make sure the request was successful
            if (resultCode == RESULT_OK)
            {
                //Get data from activity
                String month = data.getStringExtra("month");
                month = month.toLowerCase();

                switch(month)
                {
                    case "janurary":
                        months[0]++;
                        break;
                    case "february":
                        months[1]++;
                        break;
                    case "march":
                        months[2]++;
                        break;
                    case "april":
                        months[3]++;
                        break;
                    case "may":
                        months[4]++;
                        break;
                    case "june":
                        months[5]++;
                        break;
                    case "july":
                        months[6]++;
                        break;
                    case "august":
                        months[7]++;
                        break;
                    case "september":
                        months[8]++;
                        break;
                    case "october":
                        months[9]++;
                        break;
                    case "november":
                        months[10]++;
                        break;
                    case "december":
                        months[11]++;
                        break;
                    default:
                        //http stuff here
                        if(month.startsWith("http"))
                        {
                            Intent browserIntent = new Intent(Intent.ACTION_VIEW, Uri.parse(month));
                            startActivity(browserIntent);
                        }
                        else
                        {
                            monthFound = false;
                        }
                        break;
                }
                if(monthFound)
                {
                    ShowResults(month);
                }
                else
                {
                    ShowFail(month);
                }

            }
        }
    }

    private void ShowFail(String input)
    {
        String fail = "The application does not support this input: " + input;
        displayInfo.setText(fail);
    }

    private void ShowResults(String month)
    {
        String resultString = "The  barcode reader found the QR value " + month + "\n";
        for(int i = 0; i < NUM_MONTHS; i++)
        {
            resultString += monthNames[i] + " has " + months[i] + " occurances \n";
        }
        displayInfo.setText(resultString);
    }
}
