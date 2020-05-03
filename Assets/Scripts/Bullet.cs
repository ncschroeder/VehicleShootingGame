using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		other.GetComponent<Monster>().die();
		Destroy(gameObject);
		ScoreScript.incrementScore = true;
		TimeScript.timeLeft++;
	}
}
