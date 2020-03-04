package com.csc567.vehicleshootinggame

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button

class GameScreenshot : AppCompatActivity() {

    private lateinit var game_over_button: Button
    private lateinit var go_to_game_over_screen: Intent

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_game_screenshot)

        game_over_button = findViewById(R.id.game_over_button)
        game_over_button.setOnClickListener{
            go_to_game_over_screen = Intent(this, GameOverScreen::class.java)
            startActivity(go_to_game_over_screen)
        }
    }
}
