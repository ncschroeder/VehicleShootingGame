﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	int score = 0;
	public Text scoreText;

    public void incrementScore()
	{
		score++;
		scoreText.text = score.ToString();
	}
}