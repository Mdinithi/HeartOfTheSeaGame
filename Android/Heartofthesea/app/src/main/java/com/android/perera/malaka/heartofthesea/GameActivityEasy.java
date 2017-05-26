package com.android.perera.malaka.heartofthesea;

import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.GridLayout;

import com.google.firebase.crash.FirebaseCrash;

import java.util.Random;

public class GameActivityEasy extends AppCompatActivity implements View.OnClickListener {

    private int numberOfElements;
    private PicButton[] buttons;
    private int[] buttonGraphicLocations;
    private int[] buttonGraphics;

    private PicButton selectedButton1;
    private PicButton selectedButton2;

    private boolean isBusy = false;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_game_easy);

        Thread.setDefaultUncaughtExceptionHandler(new Thread.UncaughtExceptionHandler(){
            @Override
            public void uncaughtException(Thread thread, Throwable ex) {
                FirebaseCrash.report(ex);
            }
        });

        FirebaseCrash.report(new Exception("My first Android non-fatal error"));
        // FirebaseCrash.log("SQL database failed to initialize");

        GridLayout gridLayout = (GridLayout) findViewById(R.id.gridLayout_4by4);

        int numCoulmns = gridLayout.getColumnCount();
        int numRows = gridLayout.getRowCount();

        numberOfElements = numCoulmns * numRows;
        buttons = new PicButton[numberOfElements];

        buttonGraphics = new int[numberOfElements / 2];

        //storing button images to an array of buttonGrahics
        buttonGraphics[0] = R.drawable.card1;
        buttonGraphics[1] = R.drawable.card2;
        buttonGraphics[2] = R.drawable.card3;
        buttonGraphics[3] = R.drawable.card4;
        buttonGraphics[4] = R.drawable.card5;
        buttonGraphics[5] = R.drawable.card6;
        buttonGraphics[6] = R.drawable.card7;
        buttonGraphics[7] = R.drawable.card8;

        buttonGraphicLocations = new int[numberOfElements];

        shuffleButtonGraphics();

        for (int r = 0; r < numRows; r++) {
            for (int c = 0; c < numCoulmns; c++) {
                PicButton tempButton = new PicButton(this, r, c, buttonGraphics[buttonGraphicLocations[r * numCoulmns + c]]);
                tempButton.setId(View.generateViewId());
                tempButton.setOnClickListener(this);
                buttons[r * numCoulmns + c] = tempButton;
                gridLayout.addView(tempButton);
            }
        }


    }

    protected void shuffleButtonGraphics() {
        Random rand = new Random();

        for (int i = 0; i < numberOfElements; i++) {
            buttonGraphicLocations[i] = i % (numberOfElements / 2);
        }

        for (int i = 0; i < numberOfElements; i++) {
            int temp = buttonGraphicLocations[i];
            int swapIndex = rand.nextInt(16);

            buttonGraphicLocations[i] = buttonGraphicLocations[swapIndex];
            buttonGraphicLocations[swapIndex] = temp;
        }
    }

    @Override
    public void onClick(View v) {
        if(isBusy)
            return;

        PicButton button = (PicButton) v;

        if (button.isMatched)
            return;

        if (selectedButton1 == null) {
            selectedButton1 = button;
            selectedButton1.Flip();
            return;
        }

        if (selectedButton1.getId() == button.getId()) {
            return;
        }

        if (selectedButton1.getmFrontDrawableId() == button.getmFrontDrawableId()) {
            button.Flip();
            button.setMatched(true);
            selectedButton1.setEnabled(false);
            button.setEnabled(false);

            selectedButton1 = null;

            return;

        } else {
            selectedButton2 = button;
            selectedButton2.Flip();
            isBusy = true;

            final Handler handler = new Handler();
            handler.postDelayed(new Runnable() {
                @Override
                public void run() {
                    selectedButton2.Flip();
                    selectedButton1.Flip();
                    selectedButton1 = null;
                    selectedButton2 = null;
                    isBusy = false;
                }
            }, 500);
        }
    }
}
