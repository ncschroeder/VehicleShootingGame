using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script allows for different backgrounds to appear depending on which one the user chooses
public class InstantiateBackground : MonoBehaviour
{
    // These are the background picture objects
    public GameObject fieldBG, desertBG, snowBG, roadBG;
    GameObject bg;

    // bgChoice gets changed depending on the user's actions in the main menu
    public static string bgChoice;

    // Start is called before the first frame update
    void Start()
    {
        if (bgChoice == "Field")
            bg = Instantiate(fieldBG) as GameObject;
        else if (bgChoice == "Desert")
            bg = Instantiate(desertBG) as GameObject;
        else if (bgChoice == "Snow")
            bg = Instantiate(snowBG) as GameObject;
        else
            bg = Instantiate(roadBG) as GameObject;
    }
}
