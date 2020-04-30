using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour
{
    public Text timeLabel;
    void Start()
    {
        StartCoroutine(countdown());
    }

    public IEnumerator countdown()
	{
        for (int timeLeft = 20; timeLeft > 0; timeLeft--)
		{
            timeLabel.GetComponent<Text>().text = timeLeft.ToString();
            yield return new WaitForSeconds(1.0f);
        }

        SceneManager.LoadScene("MainMenu");
        //CameraMovement.moving = false;
        //updateHighScores();
	}

    void updateHighScores()
	{
        string playerName = "Player";
        string highScores = File.ReadAllText("Assets/highScores.txt");
        highScores = highScores + '\n' + playerName + ' ' + ScoreScript.score;
        File.WriteAllText("Assets/highScores.txt", highScores);
	}
}
