using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
	float maxXCoord, minXCoord;
	Vector3 position, positionOffScreen;

	void Start()
	{
		//maxXCoord = 7;
		// Have this set to the below before building an apk
		maxXCoord = Camera.main.orthographicSize * Screen.width / Screen.height - 2;
		minXCoord = maxXCoord * -1;
		position = new Vector3(0, transform.position.y, transform.position.z);
		positionOffScreen = new Vector3(50, transform.position.y, transform.position.z);
		moveToRandomPosition();
	}

	public void moveToRandomPosition()
	{
		position.x = Random.Range(minXCoord, maxXCoord);
		transform.position = position;
	}

	public void die()
	{
		transform.position = positionOffScreen;
	}
}
