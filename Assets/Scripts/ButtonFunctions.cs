using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{
    public GameObject vehicle;
    Vector3 xMovement;
    float cameraRightXCoord, cameraLeftXCoord;
    
    void Start() 
    {
        xMovement = new Vector3(0.3f, 0, 0);
        cameraRightXCoord = Camera.main.orthographicSize * Screen.width / Screen.height;
        cameraLeftXCoord = cameraRightXCoord * -1;
    }
    
    void Update() 
    {
        // if (Input.GetButton("Move Left Button"))
            // moveVehicleLeft();    
    }
    public void moveVehicleLeft()
    {
        if (vehicle.transform.position.x > cameraLeftXCoord)
                vehicle.transform.position -= xMovement;
    }

    public void moveVehicleRight() 
    {
        if (vehicle.transform.position.x < cameraRightXCoord)
                vehicle.transform.position += xMovement;
    }
}
