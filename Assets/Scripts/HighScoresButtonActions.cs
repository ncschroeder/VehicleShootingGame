using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScoresButtonActions : MonoBehaviour
{
	public void goToMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
