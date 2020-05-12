using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class NewHighScoreButtonActions : MonoBehaviour
{
	public InputField nameInput;
	public Text scoreText;
	bool scoreAddedIfHighEnough;

	void Start()
	{

	}

	public void goToMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}

	public void goToHighScores()
	{
		SceneManager.LoadScene("HighScores");
	}

	public void newGame()
	{
		SceneManager.LoadScene("GameScene");
	}

	public void updateHighScores()
	{
		// Make it so that the high scores get updated only the first time the user clicks the submit button
		if (!scoreAddedIfHighEnough)
		{
			scoreAddedIfHighEnough = true;
			Debug.Log("The score is " + ScoreScript.score.ToString());
			Debug.Log("high score 8 is " + PlayerPrefs.GetInt("HighScore8Score").ToString());
			// All of the following codes shifts the scores to the appropriate position in PlayerPrefs
			if (ScoreScript.score > PlayerPrefs.GetInt("HighScore8Score") && ScoreScript.score <= PlayerPrefs.GetInt("HighScore7Score"))
			{
				Debug.Log("score is greater than score 8 and less than or equal to score 7");
				PlayerPrefs.SetString("HighScore8Name", nameInput.text);
				PlayerPrefs.SetInt("HighScore8Score", ScoreScript.score);
			}

			else if (ScoreScript.score > PlayerPrefs.GetInt("HighScore7Score") && ScoreScript.score <= PlayerPrefs.GetInt("HighScore6Score"))
			{
				PlayerPrefs.SetString("HighScore8Name", PlayerPrefs.GetString("HighScore7Name"));
				PlayerPrefs.SetInt("HighScore8Score", PlayerPrefs.GetInt("HighScore7Score"));

				PlayerPrefs.SetString("HighScore7Name", nameInput.text);
				PlayerPrefs.SetInt("HighScore7Score", ScoreScript.score);
			}

			else if (ScoreScript.score > PlayerPrefs.GetInt("HighScore6Score") && ScoreScript.score <= PlayerPrefs.GetInt("HighScore5Score"))
			{
				PlayerPrefs.SetString("HighScore8Name", PlayerPrefs.GetString("HighScore7Name"));
				PlayerPrefs.SetInt("HighScore8Score", PlayerPrefs.GetInt("HighScore7Score"));

				PlayerPrefs.SetString("HighScore7Name", PlayerPrefs.GetString("HighScore6Name"));
				PlayerPrefs.SetInt("HighScore7Score", PlayerPrefs.GetInt("HighScore6Score"));

				PlayerPrefs.SetString("HighScore6Name", nameInput.text);
				PlayerPrefs.SetInt("HighScore6Score", ScoreScript.score);
			}
			
			else if (ScoreScript.score > PlayerPrefs.GetInt("HighScore5Score") && ScoreScript.score <= PlayerPrefs.GetInt("HighScore4Score"))
			{
				PlayerPrefs.SetString("HighScore8Name", PlayerPrefs.GetString("HighScore7Name"));
				PlayerPrefs.SetInt("HighScore8Score", PlayerPrefs.GetInt("HighScore7Score"));

				PlayerPrefs.SetString("HighScore7Name", PlayerPrefs.GetString("HighScore6Name"));
				PlayerPrefs.SetInt("HighScore7Score", PlayerPrefs.GetInt("HighScore6Score"));

				PlayerPrefs.SetString("HighScore6Name", PlayerPrefs.GetString("HighScore5Name"));
				PlayerPrefs.SetInt("HighScore6Score", PlayerPrefs.GetInt("HighScore5Score"));

				PlayerPrefs.SetString("HighScore5Name", nameInput.text);
				PlayerPrefs.SetInt("HighScore5Score", ScoreScript.score);
			}

			else if (ScoreScript.score > PlayerPrefs.GetInt("HighScore4Score") && ScoreScript.score <= PlayerPrefs.GetInt("HighScore3Score"))
			{
				PlayerPrefs.SetString("HighScore8Name", PlayerPrefs.GetString("HighScore7Name"));
				PlayerPrefs.SetInt("HighScore8Score", PlayerPrefs.GetInt("HighScore7Score"));

				PlayerPrefs.SetString("HighScore7Name", PlayerPrefs.GetString("HighScore6Name"));
				PlayerPrefs.SetInt("HighScore7Score", PlayerPrefs.GetInt("HighScore6Score"));

				PlayerPrefs.SetString("HighScore6Name", PlayerPrefs.GetString("HighScore5Name"));
				PlayerPrefs.SetInt("HighScore6Score", PlayerPrefs.GetInt("HighScore5Score"));

				PlayerPrefs.SetString("HighScore5Name", PlayerPrefs.GetString("HighScore4Name"));
				PlayerPrefs.SetInt("HighScore5Score", PlayerPrefs.GetInt("HighScore4Score"));

				PlayerPrefs.SetString("HighScore4Name", nameInput.text);
				PlayerPrefs.SetInt("HighScore4Score", ScoreScript.score);
			}

			else if (ScoreScript.score > PlayerPrefs.GetInt("HighScore3Score") && ScoreScript.score <= PlayerPrefs.GetInt("HighScore2Score"))
			{
				PlayerPrefs.SetString("HighScore8Name", PlayerPrefs.GetString("HighScore7Name"));
				PlayerPrefs.SetInt("HighScore8Score", PlayerPrefs.GetInt("HighScore7Score"));

				PlayerPrefs.SetString("HighScore7Name", PlayerPrefs.GetString("HighScore6Name"));
				PlayerPrefs.SetInt("HighScore7Score", PlayerPrefs.GetInt("HighScore6Score"));

				PlayerPrefs.SetString("HighScore6Name", PlayerPrefs.GetString("HighScore5Name"));
				PlayerPrefs.SetInt("HighScore6Score", PlayerPrefs.GetInt("HighScore5Score"));

				PlayerPrefs.SetString("HighScore5Name", PlayerPrefs.GetString("HighScore4Name"));
				PlayerPrefs.SetInt("HighScore5Score", PlayerPrefs.GetInt("HighScore4Score"));

				PlayerPrefs.SetString("HighScore4Name", PlayerPrefs.GetString("HighScore3Name"));
				PlayerPrefs.SetInt("HighScore4Score", PlayerPrefs.GetInt("HighScore3Score"));

				PlayerPrefs.SetString("HighScore3Name", nameInput.text);
				PlayerPrefs.SetInt("HighScore3Score", ScoreScript.score);
			}

			else if (ScoreScript.score > PlayerPrefs.GetInt("HighScore2Score") && ScoreScript.score <= PlayerPrefs.GetInt("HighScore1Score"))
			{
				PlayerPrefs.SetString("HighScore8Name", PlayerPrefs.GetString("HighScore7Name"));
				PlayerPrefs.SetInt("HighScore8Score", PlayerPrefs.GetInt("HighScore7Score"));

				PlayerPrefs.SetString("HighScore7Name", PlayerPrefs.GetString("HighScore6Name"));
				PlayerPrefs.SetInt("HighScore7Score", PlayerPrefs.GetInt("HighScore6Score"));

				PlayerPrefs.SetString("HighScore6Name", PlayerPrefs.GetString("HighScore5Name"));
				PlayerPrefs.SetInt("HighScore6Score", PlayerPrefs.GetInt("HighScore5Score"));

				PlayerPrefs.SetString("HighScore5Name", PlayerPrefs.GetString("HighScore4Name"));
				PlayerPrefs.SetInt("HighScore5Score", PlayerPrefs.GetInt("HighScore4Score"));

				PlayerPrefs.SetString("HighScore4Name", PlayerPrefs.GetString("HighScore3Name"));
				PlayerPrefs.SetInt("HighScore4Score", PlayerPrefs.GetInt("HighScore3Score"));

				PlayerPrefs.SetString("HighScore3Name", PlayerPrefs.GetString("HighScore2Name"));
				PlayerPrefs.SetInt("HighScore3Score", PlayerPrefs.GetInt("HighScore2Score"));

				PlayerPrefs.SetString("HighScore2Name", nameInput.text);
				PlayerPrefs.SetInt("HighScore2Score", ScoreScript.score);
			}
			
			else if (ScoreScript.score > PlayerPrefs.GetInt("HighScore1Score"))
			{
				PlayerPrefs.SetString("HighScore8Name", PlayerPrefs.GetString("HighScore7Name"));
				PlayerPrefs.SetInt("HighScore8Score", PlayerPrefs.GetInt("HighScore7Score"));

				PlayerPrefs.SetString("HighScore7Name", PlayerPrefs.GetString("HighScore6Name"));
				PlayerPrefs.SetInt("HighScore7Score", PlayerPrefs.GetInt("HighScore6Score"));

				PlayerPrefs.SetString("HighScore6Name", PlayerPrefs.GetString("HighScore5Name"));
				PlayerPrefs.SetInt("HighScore6Score", PlayerPrefs.GetInt("HighScore5Score"));

				PlayerPrefs.SetString("HighScore5Name", PlayerPrefs.GetString("HighScore4Name"));
				PlayerPrefs.SetInt("HighScore5Score", PlayerPrefs.GetInt("HighScore4Score"));

				PlayerPrefs.SetString("HighScore4Name", PlayerPrefs.GetString("HighScore3Name"));
				PlayerPrefs.SetInt("HighScore4Score", PlayerPrefs.GetInt("HighScore3Score"));

				PlayerPrefs.SetString("HighScore3Name", PlayerPrefs.GetString("HighScore2Name"));
				PlayerPrefs.SetInt("HighScore3Score", PlayerPrefs.GetInt("HighScore2Score"));

				PlayerPrefs.SetString("HighScore2Name", PlayerPrefs.GetString("HighScore1Name"));
				PlayerPrefs.SetInt("HighScore2Score", PlayerPrefs.GetInt("HighScore1Score"));

				PlayerPrefs.SetString("HighScore1Name", nameInput.text);
				PlayerPrefs.SetInt("HighScore1Score", ScoreScript.score);
			}
		}
	}
}
