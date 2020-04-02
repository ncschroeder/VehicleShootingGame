using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleScript : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 xMovement, yMovement, startCoords;
    public GameObject camera;
    float cameraMaxY = 10f;

    void Start()
    {
        xMovement = new Vector3(0.1f, 0, 0);
        yMovement = new Vector3(0, 0.1f, 0);
        startCoords = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(camera.transform.position.y);
        if (camera.transform.position.y < cameraMaxY)
        {
            transform.position += yMovement;
            camera.transform.position += yMovement;
        }
        else
		{
            transform.position = startCoords;
            camera.transform.position = startCoords;
		}

        if (Input.GetKey("left"))
        {
            if (transform.position.x > -5.6f)
                transform.position -= xMovement;
        }
        if (Input.GetKey("right"))
        {
            if (transform.position.x < 5.6f)
                transform.position += xMovement;
        }
    }
}
