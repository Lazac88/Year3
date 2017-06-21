package bit.tuckmn1.kennelclub;

import android.app.Fragment;
import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.content.Context;
import android.content.res.Resources;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import org.w3c.dom.Text;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity
{
    private String choosenBreed;
    private Fragment dogTypeListFrag;
    private ArrayList<Dog> dogList;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        choosenBreed = "";
        dogList = new ArrayList<Dog>();

        Fragment dynamicFragment = new BreedFragment();
        FragmentManager fm = getFragmentManager();
        FragmentTransaction ft = fm.beginTransaction();

        ft.replace(R.id.placeholder_for_fragment, dynamicFragment);
        ft.commit();
    }

    public void setChoosenBreed(String newBreed)
    {
        choosenBreed = newBreed;
        setBreedList(newBreed);
    }

    public void setBreedList(String newBreed)
    {
        Resources rm = getResources();
        dogList.clear();
        switch(newBreed)
        {
            case "Sporting":
                dogList.add(new Dog("Airedale", rm.getDrawable(R.drawable.airedale, null)));
                dogList.add(new Dog("Bedlington", rm.getDrawable(R.drawable.bedlington, null)));
                dogList.add(new Dog("Bull", rm.getDrawable(R.drawable.bull, null)));
                dogList.add(new Dog("Cairn", rm.getDrawable(R.drawable.cairn, null)));
                break;
            case "Hound":
                dogList.add(new Dog("Irish", rm.getDrawable(R.drawable.irish, null)));
                dogList.add(new Dog("Lakeland", rm.getDrawable(R.drawable.lakeland, null)));
                dogList.add(new Dog("Norfolk", rm.getDrawable(R.drawable.norfolk, null)));
                dogList.add(new Dog("Russell", rm.getDrawable(R.drawable.russell, null)));
                break;
            default:
                dogList.add(new Dog("Staffordshire", rm.getDrawable(R.drawable.staffordshire, null)));
                dogList.add(new Dog("Bedlington", rm.getDrawable(R.drawable.bedlington, null)));
                dogList.add(new Dog("Bull", rm.getDrawable(R.drawable.bull, null)));
                dogList.add(new Dog("Cairn", rm.getDrawable(R.drawable.cairn, null)));
                break;
        }
    }

    public ArrayList<Dog> getDogList()
    {
        return dogList;
    }

    public String getBreedString()
    {
        return choosenBreed;
    }

    public void launchNewFragment()
    {
        dogTypeListFrag = new DogListFragment();
        FragmentManager fm = getFragmentManager();
        FragmentTransaction ft = fm.beginTransaction();

        ft.replace(R.id.placeholder_for_fragment, dogTypeListFrag);
        ft.commit();
    }
}
