using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 xMovement;
    float maxRightXCoord, maxLeftXCoord;
    // Button moveLeftButton;
    void Start() 
    {
        xMovement = new Vector3(2, 0, 0);
        maxRightXCoord = Camera.main.orthographicSize * Screen.width / Screen.height - 2;
        maxLeftXCoord = maxRightXCoord * -1;
        // moveLeftButton = this.get
    }

    public void moveLeft()
	{
        if (transform.position.x > maxLeftXCoord)
            transform.position -= xMovement;
    }

    public void moveRight()
	{
        if (transform.position.x < maxRightXCoord)
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
