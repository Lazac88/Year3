package bit.tuckmn1.topartists;

import android.content.Context;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import java.util.ArrayList;

/**
 * Created by mattt on 12/04/2017.
 */

public class TrackListAdapter extends BaseAdapter
{
    private Context mContext;
    private ArrayList<Track> myTracks;

    public TrackListAdapter(Context mContext, ArrayList<Track> myTracks)
    {
        this.mContext = mContext;
        this.myTracks = myTracks;
    }

    @Override
    public int getCount()
    {
        return myTracks.size();
    }

    @Override
    public Object getItem(int i)
    {
        return myTracks.get(i);
    }

    @Override
    public long getItemId(int i)
    {
        return i;
    }

    @Override
    public View getView(int i, View view, ViewGroup viewGroup)
    {
        View tracksLayout = View.inflate(mContext, R.layout.track_listview, null);
        TextView trackNameView = (TextView) tracksLayout.findViewById(R.id.trackName_TextView);
        TextView listenersView = (TextView) tracksLayout.findViewById(R.id.listeners_TextView);

        trackNameView.setText(myTracks.get(i).getArtistName());
        int lNums = myTracks.get(i).getListenerCount();
        listenersView.setText(Integer.toString(lNums));

        //Save TrackID to tag
        tracksLayout.setTag(myTracks.get(i).getId());

        return  tracksLayout;
    }
}
