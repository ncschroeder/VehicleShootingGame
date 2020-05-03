using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{
    Vector3 xMovement;
    float maxXCoord, minXCoord;
    void Start() 
    {
        xMovement = new Vector3(2, 0, 0);
        maxXCoord = 7;
        // Have this set to the below before building an apk
        //maxXCoord = Camera.main.orthographicSize * Screen.width / Screen.height;
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
