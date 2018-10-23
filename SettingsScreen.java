package com.example.android.frogger20;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.*;

public class SettingsScreen extends AppCompatActivity {
    int diff = 1;
    TextView EMH;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_settings_screen);

        SeekBar seekBar_Difficulty = findViewById(R.id.seekBar_Difficulty);
        seekBar_Difficulty.setOnSeekBarChangeListener(seekBarChangeListener);

        int  progress = seekBar_Difficulty.getProgress();
        EMH = findViewById(R.id.textView_EMH);
    }

    SeekBar.OnSeekBarChangeListener seekBarChangeListener = new SeekBar.OnSeekBarChangeListener() {
        @Override
        public void onProgressChanged(SeekBar seekBar_Difficulty, int progress, boolean fromUser) {
            if(progress < 34) {
                EMH.setText("Easy");
            }
            else if(progress > 33 && progress < 67) {
                EMH.setText("Medium");
                diff = 2;
            }
            else if(progress > 66) {
                EMH.setText("Hard");
                diff = 3;
            }
        }

        @Override
        public void onStartTrackingTouch(SeekBar seekBar_Difficulty) {

        }

        @Override
        public void onStopTrackingTouch(SeekBar seekBar_Difficulty) {

        }
    };
}
