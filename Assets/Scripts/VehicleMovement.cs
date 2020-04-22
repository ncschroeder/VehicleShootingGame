using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovement : MonoBehaviour
{
    Vector3 xMovement;
    float maxXCoord, minXCoord;

    void Start()
    {
        xMovement = new Vector3(2, 0, 0);
        maxXCoord = Camera.main.orthographicSize * Screen.width / Screen.height - 2;
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
}
