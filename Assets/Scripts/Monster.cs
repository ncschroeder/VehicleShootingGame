using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
	float maxXCoord, minXCoord;
	Vector3 positionOffScreen;

	void Start()
	{
		maxXCoord = Camera.main.orthographicSize * Screen.width / Screen.height - 2;
		minXCoord = maxXCoord * -1;
		positionOffScreen = new Vector3(maxXCoord + 4, transform.position.y, transform.position.z);
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		//Debug.Log("monster hit");
	}

	public void die()
	{
		transform.position = positionOffScreen;
	}
}
