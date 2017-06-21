package bit.tuckmn1.welcometodunedin2;

import android.app.Fragment;
import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

public class MainActivity extends AppCompatActivity {


    String choosenThing;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        choosenThing = "";

        Fragment dynamicFragment = new ListFragment();
        FragmentManager fm = getFragmentManager();
        FragmentTransaction ft = fm.beginTransaction();

        ft.replace(R.id.listFragmentPlaceholder, dynamicFragment);
        ft.commit();
    }

    public String getChoosenThing()
    {
        return choosenThing;
    }

    public void setChoosenThing(String choice)
    {
        choosenThing = choice;
    }
}
