package bit.tuckmn1.topartists;


import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.AsyncTask;
import android.os.Bundle;
import android.app.DialogFragment;
import android.app.Fragment;
import android.os.Environment;
import android.provider.MediaStore;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.concurrent.ExecutionException;

/**
 * A simple {@link Fragment} subclass.
 */
public class ArtistImageFragment extends DialogFragment
{
    ImageView myImage;
    Bitmap artistImage;

    public ArtistImageFragment()
    {
        // Required empty public constructor
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
    {
        View dialogViewImage = inflater.inflate(R.layout.artist_image_frag_layout, container, false);
        myImage = (ImageView) dialogViewImage.findViewById(R.id.artistDialogImage);
        artistImage = null;

        String artistImageURL = getArguments().getString("imgURL");

        AsyncGetImageBitmap asyncGetImageBitmap = new AsyncGetImageBitmap();
        asyncGetImageBitmap.execute(artistImageURL);
        try
        {
            asyncGetImageBitmap.get();
        }
        catch (InterruptedException e)
        {
            e.printStackTrace();
        }
        catch (ExecutionException e)
        {
            e.printStackTrace();
        }

        //Log.i("Set img to IView", artistImage.toString());
        myImage.setImageBitmap(artistImage);

        Log.i("TAG", "Ready to return view");
        return dialogViewImage;
    }

    class AsyncGetImageBitmap extends AsyncTask<String, Void, Bitmap>
    {
        @Override
        protected Bitmap doInBackground(String... params)
        {
            //Declare here so not local to the try block
            String JSONString = null;
            String artistURL = params[0];
            //Bitmap artistImage = null;

            HttpURLConnection connection = null;
            try
            {
                //Convert URL string to URLObject
                URL URLObject = new URL(artistURL);

                //Create HttpURLConnection object via openConnection command
                connection = (HttpURLConnection) URLObject.openConnection();

                //Send the URL
                connection.connect();

                //Grab response code and check if response is successful
                int resCode = connection.getResponseCode();
                if (resCode == 200)
                {
                    InputStream is = connection.getInputStream();
                    artistImage = BitmapFactory.decodeStream(is);
                }
            }
            catch (Exception e)
            {
                Log.i("URL EXCEPTION", "Getting bitmap image failed");
                e.printStackTrace();
                connection.disconnect();
                return null;
            }
            Log.i("TAG", artistImage.toString());

            return artistImage;
        }

        @Override
        protected void onPostExecute(Bitmap fetchedBitmap)
        {
            Log.i("TAG", "Setting fetchedBitmap to global variable");
            artistImage = fetchedBitmap;
        }
    }
}
