using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is attached to the camera objects in the menu scenes. It moves the camera every frame but this movement is not noticeable.
// The reason I am using this script is because when I build an apk, the menus are just squares and tiny but the game screen is zoomed in.
// The game screen features a moving camera, so if I make the camera in the menus moving then they will also be zoomed in.
public class MenuCameraScript : MonoBehaviour
{
    bool moveUp;
    Vector3 cameraPosition;

    // This function gets called when a menu is visited
    void Start()
	{
        moveUp = true;
        cameraPosition = transform.position;
	}

    // Update is called once per frame
    void Update()
    {
        if (moveUp)
		{
            cameraPosition.y += 20;
            transform.position = cameraPosition;
            moveUp = false;
		} 
        else
		{
            cameraPosition.y -= 20;
            transform.position = cameraPosition;
            moveUp = true;
		}
    }
}
