using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 xMovement;
    float cameraRightXCoord, cameraLeftXCoord;
    // Button moveLeftButton;
    void Start() 
    {
        xMovement = new Vector3(0.3f, 0, 0);
        cameraRightXCoord = Camera.main.orthographicSize * Screen.width / Screen.height;
        cameraLeftXCoord = cameraRightXCoord * -1;
        // moveLeftButton = this.get
    }
    void Update()
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
    }
}
