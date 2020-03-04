package com.csc567.vehicleshootinggame

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button

class GameOverScreen : AppCompatActivity() {

    private lateinit var new_game_button: Button
    private lateinit var game_over_menu_button: Button
    private lateinit var start_new_game: Intent
    private lateinit var go_to_menu: Intent

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_game_over_screen)

        new_game_button = findViewById(R.id.new_game_button)
        game_over_menu_button = findViewById(R.id.game_over_menu_button)

        new_game_button.setOnClickListener{
            start_new_game = Intent(this, GameScreenshot::class.java)
            startActivity(start_new_game)
        }

        game_over_menu_button.setOnClickListener{
            go_to_menu = Intent(this, MainActivity::class.java)
            startActivity(go_to_menu)
        }
    }
}
