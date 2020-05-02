using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSceneSwitcher : MonoBehaviour
{
	public void play()
	{
		SceneManager.LoadScene("GameScene");
	}

	public void goToHighScores()
	{
		SceneManager.LoadScene("HighScores");
	}
}
