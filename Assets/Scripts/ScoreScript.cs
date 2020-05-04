using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
	public static bool incrementScore;
	public static int score;
	public Text scoreText;
	public Text speedIncreasedText;

	void Start()
	{
		incrementScore = false;
		score = 0;
	}

    void Update()
	{
		// incrementScore becomes true when a bullet enters a monster. This is seen in Bullet.cs.
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

				StartCoroutine(showSpeedIncreasedText());
			}
		}
	}

	IEnumerator showSpeedIncreasedText()
	{
		// Show "speed increased" at the top of the screen for 1 second
		speedIncreasedText.enabled = true;
		yield return new WaitForSeconds(1);
		speedIncreasedText.enabled = false;
	}
}
