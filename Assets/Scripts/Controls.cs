using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 xMovement;
    float maxXCoord, minXCoord;
    // Button moveLeftButton;
    void Start() 
    {
        xMovement = new Vector3(2, 0, 0);
        maxXCoord = Camera.main.orthographicSize * Screen.width / Screen.height - 2;
        minXCoord = maxXCoord * -1;
        // moveLeftButton = this.get
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
    /*void Update()
    {   
        if (Input.GetKey("left"))
        {
            if (transform.position.x > cameraLeftXCoord)
                transform.position -= xMovement;
        }
        if (Input.GetKey("right"))
        {
            if (transform.position.x < cameraRightXCoord)
                transform.position += xMovement;
        }
    }*/
}
