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
	bool scoreAdded;

	void Start()
	{
		PlayerPrefs.SetInt("HighScore1Score", 1);
		PlayerPrefs.SetString("HighScore1Name", "T");
		scoreAdded = false;
		//scoreText.text = ScoreScript.score.ToString();
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
		string tempName;
		int tempScore;

		// Make it so that the high scores get updated only the first time the user clicks the submit button
		if (!scoreAdded)
		{
			/*string playerName = nameInput.text;
			string highScores = File.ReadAllText("Assets/highScores.txt");
			highScores = highScores + '\n' + playerName + ' ' + ScoreScript.score;
			//string[] highScoreLines = highScores.Split('\n');
			File.WriteAllText("Assets/highScores.txt", highScores);*/

			scoreAdded = true;

		}
	}

	/*string[] getSortedScores(string[] highScoreLines)
	{
		// Use insertion sort to get top 10 scores
		int numberOfScores = highScoreLines.Length;
		int j, key;
		for (int i = 1; i < numberOfScores; i++)
		{
			key = getHighScore(highScoreLines[i]);
			j = i - 1;
			while (j > 0 && getHighScore(highScoreLines[j]) > key)
			{
				highScoreLines[j + 1] = highScoreLines[j];
				j--;
			}
			highScoreLines[j + 1] = highScoreLines[i];
		}
		if (numberOfScores <= 10)
			return highScoreLines;
		else
		{
			string[] top10Scores = new string[10];
			for (int i = 0; i < 10; i++)
				top10Scores[i] = highScoreLines[i];
			return top10Scores;
		}
	}

	int getHighScore(string highScoreEntry)
	{
		return int.Parse(highScoreEntry.Split(' ')[1]);
	}*/
}
