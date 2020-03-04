package com.csc567.vehicleshootinggame

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button

class Scores : AppCompatActivity() {

    private lateinit var menu_button: Button
    private lateinit var go_to_menu: Intent

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_scores)

        menu_button = findViewById(R.id.scores_menu_button)
        menu_button.setOnClickListener{
            go_to_menu = Intent(this, MainActivity::class.java)
            startActivity(go_to_menu)
        }
    }
}
