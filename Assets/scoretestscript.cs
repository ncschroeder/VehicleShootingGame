using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class scoretestscript : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        string highScores = File.ReadAllText("assets/highscores.txt");
        text.text = highScores;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
