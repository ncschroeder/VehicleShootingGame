using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMonstersScript : MonoBehaviour
{
    public GameObject[] monsters;
	float maxXCoord, minXCoord;
	Vector3 positionCoords;
    
    public void Start()
	{
		maxXCoord = Camera.main.orthographicSize * Screen.width / Screen.height - 2;
		minXCoord = maxXCoord * -1;
		positionCoords = new Vector3();
		moveMonsters();
	}
	
	public void moveMonsters()
	{
        foreach (GameObject monster in monsters)
		{
			positionCoords.y = monster.transform.position.y;
			positionCoords.x = Random.Range(minXCoord, maxXCoord);
			monster.transform.position = positionCoords;
		}
	}
}
