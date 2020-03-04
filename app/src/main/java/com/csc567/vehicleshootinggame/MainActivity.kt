package com.csc567.vehicleshootinggame

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button

class MainActivity : AppCompatActivity() {

    private lateinit var play_button: Button
    private lateinit var scores_button: Button
    private lateinit var go_to_scores: Intent
    private lateinit var go_to_game: Intent

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        play_button = findViewById<Button>(R.id.play_button)
        scores_button = findViewById<Button>(R.id.scores_button)

        play_button.setOnClickListener{
            go_to_game = Intent(this, GameScreenshot::class.java)
            startActivity(go_to_game)
        }

        scores_button.setOnClickListener{
            go_to_scores = Intent(this, Scores::class.java)
            startActivity(go_to_scores)
        }
    }
}
