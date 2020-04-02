using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneScript : MonoBehaviour
{
    public GameObject vehicle, camera;
    Vector3 xMovement, yMovement, vehicleStartCoords, cameraStartCoords;
    //Vector2 screenBoundaries;
    float cameraMaxY, vehicleMinX, vehicleMaxX;

    // Start is called before the first frame update
    void Start()
    {
        xMovement = new Vector3(0.1f, 0, 0);
        yMovement = new Vector3(0, 0.1f, 0);
        vehicleStartCoords = new Vector3(0, -7.6f, 0);
        cameraStartCoords = new Vector3(0, 0, -10);

        //screenBoundaries = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        cameraMaxY = 25;
        vehicleMinX = -9.4f;
        vehicleMaxX = 9.4f;

        vehicle.transform.position = vehicleStartCoords;
        camera.transform.position = cameraStartCoords;
    }

    // Update is called once per frame
    void Update()
    {
        if (camera.transform.position.y < cameraMaxY)
        {
            vehicle.transform.position += yMovement;
            camera.transform.position += yMovement;
        }
        else
        {
            vehicleStartCoords.x = vehicle.transform.position.x;
            vehicle.transform.position = vehicleStartCoords;
            camera.transform.position = cameraStartCoords;
        }

        if (Input.GetKey("left"))
        {
            if (vehicle.transform.position.x > vehicleMinX)
                vehicle.transform.position -= xMovement;
        }
        if (Input.GetKey("right"))
        {
            if (vehicle.transform.position.x < vehicleMaxX)
                vehicle.transform.position += xMovement;
        }
    }
}
