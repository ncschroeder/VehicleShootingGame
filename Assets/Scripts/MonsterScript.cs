using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is attached to every monster in the game
public class MonsterScript : MonoBehaviour
{
	float maxXCoord, minXCoord;
	Vector3 position, positionOffScreen;

	void Start()
	{
		// The maxXCoord and minXCoord set boundaries for how far left and right the monsters can appear
		maxXCoord = Camera.main.orthographicSize * Screen.width / Screen.height - 1;
		minXCoord = maxXCoord * -1;
		position = new Vector3(0, transform.position.y, transform.position.z);
		positionOffScreen = new Vector3(50, transform.position.y, transform.position.z);
		moveToRandomPosition();
	}

	// This function gets called on every monster when the camera gets to it's highest spot and goes back to the starting spot,
	// bringing the vehicle along with it
	public void moveToRandomPosition()
	{
		position.x = Random.Range(minXCoord, maxXCoord);
		transform.position = position;
	}

	// This function gets called when a monster is shot. transform.positon refers to the position of the monster.
	public void moveOffScreen()
	{
		transform.position = positionOffScreen;
	}
}
