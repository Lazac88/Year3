package bit.tuckmn1.week2eventhandler;

import android.content.DialogInterface;
import android.os.Message;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.text.Editable;
import android.view.KeyEvent;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import java.io.Console;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //Creating a reference to my button and creating an instance of my inner class which holds my event handlers
        Button myButton = (Button) findViewById(R.id.ClickButton);
        ButtonClickDisplay buttonClickDisplay = new ButtonClickDisplay();

        //binding the instance of the inner class to my button
        myButton.setOnClickListener(buttonClickDisplay);
        myButton.setOnLongClickListener(buttonClickDisplay);

        //Creating a reference to myTextField
        EditText myTextField = (EditText) findViewById(R.id.myTextField);
        TextInputWarning myWarning = new TextInputWarning();

        //binding my text field
        myTextField.setOnKeyListener(myWarning);

        //Creating a reference to UserNameText
        EditText userNameText = (EditText) findViewById(R.id.userNameText);
        UserNameWarning userWarning = new UserNameWarning(userNameText);

        //binding my text field
        userNameText.setOnKeyListener(userWarning);
    }

    public class ButtonClickDisplay implements View.OnClickListener, View.OnLongClickListener
    {

        @Override
        public void onClick(View v) {
            Toast makeShortClick = Toast.makeText(MainActivity.this, "Short Click", Toast.LENGTH_LONG);
            makeShortClick.show();
        }

        @Override
        public boolean onLongClick(View v) {

            Toast makeLongClick = Toast.makeText(MainActivity.this, "Long Click", Toast.LENGTH_LONG);
            makeLongClick.show();

            return true;
        }
    }

    public class TextInputWarning implements View.OnKeyListener
    {

        @Override
        public boolean onKey(View v, int keyCode, KeyEvent event)
        {
            Toast makeText = Toast.makeText(MainActivity.this, "Don't Press @", Toast.LENGTH_LONG);

            if(keyCode == KeyEvent.KEYCODE_AT)
            {
                if(event.getAction() == KeyEvent.ACTION_DOWN)
                {
                    makeText.show();
                }

            }
            return false;
        }
    }

    public class UserNameWarning implements View.OnKeyListener
    {
        EditText myTextBox;
        public UserNameWarning(EditText textBox)
        {
            myTextBox = textBox;
        }
        @Override
        public boolean onKey(View v, int keyCode, KeyEvent event)
        {
            if(keyCode == KeyEvent.KEYCODE_ENTER)
            {
                if(event.getAction() == KeyEvent.ACTION_DOWN)
                {

                    Editable userInput = myTextBox.getText();
                    String userName = userInput.toString();
                    //System.out.println(userName + userName.length());
                    if(userName.length() < 8 || userName.length() > 8)
                    {
                        Toast makeUserText = Toast.makeText(MainActivity.this, "UserNames must be 8 characters long, " + userName, Toast.LENGTH_LONG);
                        makeUserText.show();
                    }
                    else
                    {
                        Toast makeUserText = Toast.makeText(MainActivity.this, "Thanks for that, " + userName, Toast.LENGTH_LONG);
                        makeUserText.show();
                    }

                }

            }
            return false;
        }
    }
}
