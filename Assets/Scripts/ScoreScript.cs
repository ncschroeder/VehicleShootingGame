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
			incrementScore = false;
			score++;
			scoreText.text = score.ToString();

			// Make speed increase every time a multiple of 5 is reached
			if (score % 5 == 0)
			{
				CameraMovement.increaseSpeed();

				// Make bullets go faster
				BulletHolder.bulletSpeed += 200;
				Debug.Log("Speed increased");
			}
		}
	}
}
