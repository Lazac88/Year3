package bit.tuckmn1.topartists;

import android.content.Context;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import java.util.ArrayList;

/**
 * Created by mattt on 14/04/2017.
 */

public class ArtistListAdapter extends BaseAdapter
{
    private Context mContext;
    private ArrayList<Artist> myArtists;

    public ArtistListAdapter(Context mContext, ArrayList<Artist> myArtists)
    {
        this.mContext = mContext;
        this.myArtists = myArtists;
    }

    @Override
    public int getCount()
    {
        return myArtists.size();
    }

    @Override
    public Object getItem(int i)
    {
        return myArtists.get(i);
    }

    @Override
    public long getItemId(int i)
    {
        return i;
    }

    @Override
    public View getView(int i, View view, ViewGroup viewGroup)
    {
        View artistsLayout = View.inflate(mContext, R.layout.track_listview, null);
        TextView artistNameView = (TextView) artistsLayout.findViewById(R.id.trackName_TextView);
        TextView listenersView = (TextView) artistsLayout.findViewById(R.id.listeners_TextView);

        artistNameView.setText(myArtists.get(i).getName());
        int lNums = myArtists.get(i).getListeners();
        listenersView.setText(Integer.toString(lNums));

        //Save TrackID to tag
        artistsLayout.setTag(myArtists.get(i).getId());

        return  artistsLayout;
    }
}
