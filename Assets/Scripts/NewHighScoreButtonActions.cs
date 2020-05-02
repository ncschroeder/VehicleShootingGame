using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class NewHighScoreButtonActions : MonoBehaviour
{
	public InputField nameInput;
	public Text congratsText;
	bool scoreAdded;

	void Start()
	{
		scoreAdded = false;
		congratsText.text = congratsText.text + ' ' + ScoreScript.score.ToString();
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
		if (!scoreAdded)
		{
			string playerName = nameInput.text;
			string highScores = File.ReadAllText("Assets/highScores.txt");
			highScores = highScores + '\n' + playerName + ' ' + ScoreScript.score;
			File.WriteAllText("Assets/highScores.txt", highScores);
			scoreAdded = true;
		}
	}
}
