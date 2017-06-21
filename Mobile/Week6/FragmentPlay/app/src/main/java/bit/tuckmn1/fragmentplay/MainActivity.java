package bit.tuckmn1.fragmentplay;

import android.app.Fragment;
import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity
{

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.tablet_both_fragments);

        Button showImageFragment = (Button) findViewById(R.id.imageButton);
        showImageFragment.setOnClickListener(new buttonImageEventHandler());

        Button showListFragment = (Button) findViewById(R.id.listButton);
        showListFragment.setOnClickListener(new buttonListEventHandler());
    }

    public class buttonImageEventHandler implements View.OnClickListener
    {

        @Override
        public void onClick(View view)
        {
            Fragment dynamicFragment = new ImageFragment();
            FragmentManager fm = getFragmentManager();

            FragmentTransaction ft = fm.beginTransaction();
            ft.replace(R.id.imageFragmentContainer, dynamicFragment);
            ft.commit();
        }
    }

    public class buttonListEventHandler implements View.OnClickListener
    {

        @Override
        public void onClick(View view)
        {
            Fragment dynamicFragment = new ListViewFragment();
            FragmentManager fm = getFragmentManager();

            FragmentTransaction ft = fm.beginTransaction();
            ft.replace(R.id.listFragmentContainer, dynamicFragment);
            ft.commit();
        }
    }
}
