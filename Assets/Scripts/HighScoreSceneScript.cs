using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class HighScoreSceneScript : MonoBehaviour
{
	public Text scoreText;

	void Start()
	{
		scoreText.text = File.ReadAllText("assets/highscores.txt");
	}

	public void goToMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
