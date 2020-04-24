using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public Text timeLabel;
    void Start()
    {
        StartCoroutine(countdown());
    }

    public IEnumerator countdown()
	{
        int timeLeft = 20;
        while (timeLeft > 0)
		{
            timeLabel.GetComponent<Text>().text = timeLeft.ToString();
            timeLeft--;
            yield return new WaitForSeconds(1.0f);
        }
        CameraMovement.moving = false;
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
