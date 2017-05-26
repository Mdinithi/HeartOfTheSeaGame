package com.android.perera.malaka.heartofthesea;

import android.content.Context;
import android.graphics.drawable.Drawable;
import android.support.v7.widget.AppCompatDrawableManager;
import android.widget.GridLayout;

/**
 * Created by Acer on 2017-05-21.
 */

public class PicButton extends android.support.v7.widget.AppCompatButton {

    protected int mRow;
    protected int mColumn;
    protected int mFrontDrawableId;

    protected boolean isFlipped = false;
    protected boolean isMatched = false;

    protected Drawable front;
    protected Drawable back;

    public PicButton(Context context, int row, int column, int frontImageDrawableId)
    {
        super(context);

        mRow = row;
        mColumn = column;
        mFrontDrawableId = frontImageDrawableId;

        front = AppCompatDrawableManager.get().getDrawable(context, frontImageDrawableId);
        back = AppCompatDrawableManager.get().getDrawable(context, R.drawable.heartlevel1);
        setBackground(back);

        GridLayout.LayoutParams tempParams = new GridLayout.LayoutParams(GridLayout.spec(mRow), GridLayout.spec(mColumn));

        //Controlling the size of the image with the size of the device
        tempParams.width = (int) getResources().getDisplayMetrics().density * 120;
        tempParams.height = (int) getResources().getDisplayMetrics().density * 120;

        setLayoutParams(tempParams);

    }

    public boolean isMatched() {
        return isMatched;
    }

    public void setMatched(boolean matched) {
        isMatched = matched;
    }

    public int getmFrontDrawableId() {
        return mFrontDrawableId;
    }

    public void Flip()
    {
        if(isMatched)
            return;

        if(isFlipped)
        {
            setBackground(back);
            isFlipped = false;
        }
        else {
            setBackground(front);
            isFlipped = true;
        }
    }
}
