package bit.tuckmn1.dunedinapp;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;

public class HomePage extends AppCompatActivity
{

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_home_page);

        setUpListDrawer();

        //Find my listbox (drawer) and set it to listen for a click.
        //On Item Click it will respond with the code from my onItemClick Handler
        ListView myDrawer = (ListView) findViewById(R.id.left_drawer);
        myDrawer.setOnItemClickListener(new drawClickHandler());
    }

    public void setUpListDrawer()
    {
        //A java array of Dunedin Activities
        String[] thingsToDo = new String[] { "Activities", "Shopping", "Dining", "Services" };
        ArrayAdapter<String> dunedinThingsAdapter = new ArrayAdapter<String>(this, R.layout.drawer_list_layout, thingsToDo);

        ListView dunedinThings = (ListView) findViewById(R.id.left_drawer);

        dunedinThings.setAdapter(dunedinThingsAdapter);
    }

    public class drawClickHandler implements AdapterView.OnItemClickListener
    {
        @Override
        public void onItemClick(AdapterView<?> parent, View view, int position, long id)
        {
            String clickedItemString = (String) parent.getItemAtPosition(position).toString();
            //Toast.makeText(HomePage.this, clickedItemString, Toast.LENGTH_LONG).show();
            Intent changePage;

            switch(clickedItemString)
            {
                case "Activities":
                    changePage = new Intent(HomePage.this, DunedinActivity.class);
                    break;
                case "Shopping":
                    changePage = new Intent(HomePage.this, DunedinShopping.class);
                    break;
                case "Dining":
                    changePage = new Intent(HomePage.this, DunedinDining.class);
                    break;
                case "Services":
                    changePage = new Intent(HomePage.this, DunedinServices.class);
                    break;
                default:
                    changePage = null;
            }

            if(changePage != null)
            {
                startActivity(changePage);
            }
        }
    }
}
