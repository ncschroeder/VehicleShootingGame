using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstersCollection : MonoBehaviour
{
    public GameObject[] monsters;
	float maxXCoord, minXCoord;
	Vector3 positionCoords;
    
    public void Start()
	{
		maxXCoord = Camera.main.orthographicSize * Screen.width / Screen.height - 2;
		minXCoord = maxXCoord * -1;
		positionCoords = new Vector3();
		move();
	}
	
	public void move()
	{
        foreach (GameObject monster in monsters)
		{
			positionCoords.y = monster.transform.position.y;
			positionCoords.x = Random.Range(minXCoord, maxXCoord);
			monster.transform.position = positionCoords;
		}
	}
}
