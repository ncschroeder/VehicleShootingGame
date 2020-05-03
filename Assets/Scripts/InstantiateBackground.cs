using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBackground : MonoBehaviour
{
    public GameObject fieldBG, desertBG, snowBG, roadBG;
    GameObject bg;

    // Have bgChoice be Field by default since that is the default option in the drop down menu.
    public static string bgChoice = "Field";

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
