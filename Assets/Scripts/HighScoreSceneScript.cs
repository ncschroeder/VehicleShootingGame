using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class HighScoreSceneScript : MonoBehaviour
{
	public Text scoreText1, scoreText2, scoreText3, scoreText4, 
		scoreText5, scoreText6, scoreText7, scoreText8;

	// This function gets called when the high scores menu is visited
	void Start()
	{
		// PlayerPrefs is short for player preferences and can be used to store simple information that gets saved when the 
		// user shuts down the app. 
		if (!PlayerPrefs.HasKey("ScoresCreated"))
		{
			PlayerPrefs.SetInt("ScoresCreated", 1);
			createHighScores();
			PlayerPrefs.Save();
		}
		//clearHighScores();
		displayHighScores();
	}

	public void goToMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}

	void displayHighScores()
	{
		string displayText;
		if (PlayerPrefs.GetString("HighScore1Name") != "")
		{
			displayText = PlayerPrefs.GetString("HighScore1Name") + "  " + PlayerPrefs.GetInt("HighScore1Score").ToString();
			scoreText1.text = displayText;
		}

		if (PlayerPrefs.GetString("HighScore2Name") != "")
		{
			displayText = PlayerPrefs.GetString("HighScore2Name") + "  " + PlayerPrefs.GetInt("HighScore2Score").ToString();
			scoreText2.text = displayText;
		}

		if (PlayerPrefs.GetString("HighScore3Name") != "")
		{
			displayText = PlayerPrefs.GetString("HighScore3Name") + "  " + PlayerPrefs.GetInt("HighScore3Score").ToString();
			scoreText3.text = displayText;
		}

		if (PlayerPrefs.GetString("HighScore4Name") != "")
		{
			displayText = PlayerPrefs.GetString("HighScore4Name") + "  " + PlayerPrefs.GetInt("HighScore4Score").ToString();
			scoreText4.text = displayText;
		}

		if (PlayerPrefs.GetString("HighScore5Name") != "")
		{
			displayText = PlayerPrefs.GetString("HighScore5Name") + "  " + PlayerPrefs.GetInt("HighScore5Score").ToString();
			scoreText5.text = displayText;
		}

		if (PlayerPrefs.GetString("HighScore6Name") != "")
		{
			displayText = PlayerPrefs.GetString("HighScore6Name") + "  " + PlayerPrefs.GetInt("HighScore6Score").ToString();
			scoreText6.text = displayText;
		}

		if (PlayerPrefs.GetString("HighScore7Name") != "")
		{
			displayText = PlayerPrefs.GetString("HighScore7Name") + "  " + PlayerPrefs.GetInt("HighScore7Score").ToString();
			scoreText7.text = displayText;
		}

		if (PlayerPrefs.GetString("HighScore8Name") != "")
		{
			displayText = PlayerPrefs.GetString("HighScore8Name") + "  " + PlayerPrefs.GetInt("HighScore8Score").ToString();
			scoreText8.text = displayText;
		}
	}

	// Used in development but not in the final product
	void clearHighScores()
	{
		PlayerPrefs.SetInt("HighScore1Score", 0);
		PlayerPrefs.SetString("HighScore1Name", "");

		PlayerPrefs.SetInt("HighScore2Score", 0);
		PlayerPrefs.SetString("HighScore2Name", "");

		PlayerPrefs.SetInt("HighScore3Score", 0);
		PlayerPrefs.SetString("HighScore3Name", "");

		PlayerPrefs.SetInt("HighScore4Score", 0);
		PlayerPrefs.SetString("HighScore4Name", "");

		PlayerPrefs.SetInt("HighScore5Score", 0);
		PlayerPrefs.SetString("HighScore5Name", "");

		PlayerPrefs.SetInt("HighScore6Score", 0);
		PlayerPrefs.SetString("HighScore6Name", "");

		PlayerPrefs.SetInt("HighScore7Score", 0);
		PlayerPrefs.SetString("HighScore7Name", "");

		PlayerPrefs.SetInt("HighScore8Score", 0);
		PlayerPrefs.SetString("HighScore8Name", "");
	}

	void createHighScores()
	{
		int score = 10;

		PlayerPrefs.SetInt("HighScore1Score", score);
		PlayerPrefs.SetString("HighScore1Name", "Ken");

		score--;

		PlayerPrefs.SetInt("HighScore2Score", score);
		PlayerPrefs.SetString("HighScore2Name", "Jen");

		score--;

		PlayerPrefs.SetInt("HighScore3Score", score);
		PlayerPrefs.SetString("HighScore3Name", "Louie");

		score--;

		PlayerPrefs.SetInt("HighScore4Score", score);
		PlayerPrefs.SetString("HighScore4Name", "Ashley");

		score--;

		PlayerPrefs.SetInt("HighScore5Score", score);
		PlayerPrefs.SetString("HighScore5Name", "Mark");

		score--;

		PlayerPrefs.SetInt("HighScore6Score", score);
		PlayerPrefs.SetString("HighScore6Name", "Ivy");

		score--;

		PlayerPrefs.SetInt("HighScore7Score", score);
		PlayerPrefs.SetString("HighScore7Name", "Thaddeus");

		score--;

		PlayerPrefs.SetInt("HighScore8Score", score);
		PlayerPrefs.SetString("HighScore8Name", "Libby");
	}
}
