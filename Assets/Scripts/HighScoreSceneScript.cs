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

	void Start()
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
		//scoreText.text = File.ReadAllText("assets/highscores.txt");
	}

	public void goToMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
