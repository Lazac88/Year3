package bit.tuckmn1.dialogfragmentplay;

import android.app.DialogFragment;
import android.app.Fragment;
import android.app.FragmentManager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;

public class MainActivity extends AppCompatActivity {

    PizzaConfirmFragment confirm;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button orderPizzaBtn = (Button) findViewById(R.id.orderPizzaBtn);
        orderPizzaBtn.setOnClickListener(new orderPizzaBtnHandler());

        confirm = null;
    }

    public class orderPizzaBtnHandler implements View.OnClickListener
    {

        @Override
        public void onClick(View v)
        {
            FragmentManager fm = getFragmentManager();
            confirm = new PizzaConfirmFragment();
            confirm.show(fm, "confirm");
        }
    }

    public void getConfirmData(boolean orderPizza)
    {
        confirm.dismiss();

        ImageView myImage = (ImageView) findViewById(R.id.imageViewResult);
        {
            if(orderPizza)
            {
                myImage.setImageResource(R.drawable.pizza);
            }
            else
            {
                myImage.setImageResource(R.drawable.no_pizza);
            }
        }
    }
}
