using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
	public Text bgLabel;
	public void play()
	{
		SceneManager.LoadScene("GameScene");
	}

	public void goToHighScores()
	{
		SceneManager.LoadScene("HighScores");
	}

	public void switchBG()
	{
		InstantiateBackground.bgChoice = bgLabel.text;
		//Debug.Log("bg is " + bgLabel.text);
	}
}
