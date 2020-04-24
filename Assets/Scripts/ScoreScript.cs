using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
	public static bool incrementScore;
	public static int score;
	public Text scoreText;

	void Start()
	{
		incrementScore = false;
		score = 0;
	}

    void Update()
	{
		if (incrementScore)
		{
			score++;
			scoreText.text = score.ToString();
			incrementScore = false;
		}
	}
}
