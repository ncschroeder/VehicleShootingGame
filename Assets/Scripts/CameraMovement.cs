using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject monstersCollection;
    Vector3 yMovement, moveBackDistance;
    float maxYCoord = 110;

    void Start()
    {
        // Move up distance
        yMovement = new Vector3(0, 0.1f, 0);

        // Move back to starting position after vehicle reaches top of background
        moveBackDistance = new Vector3(0, maxYCoord, 0);
    }

    void Update()
    {
        if (transform.position.y < maxYCoord)
            transform.position += yMovement;
        else
        {
            // Make monsters move to new position
            monstersCollection.GetComponent<MonstersCollection>().move();
            transform.position -= moveBackDistance;
        }
    }
}
