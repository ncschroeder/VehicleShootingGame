using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject monstersCollection;
    Vector3 yMovement, moveBackDistance;
    float maxYCoord = 110;
    // Start is called before the first frame update
    void Start()
    {
        yMovement = new Vector3(0, 0.1f, 0);
        moveBackDistance = new Vector3(0, maxYCoord, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < maxYCoord)
            transform.position += yMovement;
        else
        {
            monstersCollection.GetComponent<MoveMonstersScript>().moveMonsters();
            transform.position -= moveBackDistance;
        }
    }
}
