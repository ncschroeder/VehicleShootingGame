using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Script for vehicle controls
public class Controls : MonoBehaviour
{
    Vector3 xMovement;
    float maxXCoord, minXCoord;

    void Start() 
    {
        // xMovement makes the vehicle move 2 units to the left or right
        xMovement = new Vector3(2, 0, 0);

        // The following code sets boundaries for how far the vehicle can go
        maxXCoord = Camera.main.orthographicSize * Screen.width / Screen.height - 1;
        minXCoord = maxXCoord * -1;
    }

    public void moveLeft()
	{
        if (transform.position.x > minXCoord)
            transform.position -= xMovement;
    }

    public void moveRight()
	{
        if (transform.position.x < maxXCoord)
            transform.position += xMovement;
    }

    void Update()
	{
        if (Input.GetKeyDown("left"))
            moveLeft();
        if (Input.GetKeyDown("right"))
            moveRight();
	}
}
