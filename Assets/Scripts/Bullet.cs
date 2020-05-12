using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		other.GetComponent<MonsterScript>().moveOffScreen();
		Destroy(gameObject);
		ScoreScript.incrementScore = true;
		TimeScript.incrementTime = true;
	}
}
