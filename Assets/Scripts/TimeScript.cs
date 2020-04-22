using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public Text timeLabel;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(countdown());
    }

    public IEnumerator countdown()
	{
        int timeLeft = 10;
        while (timeLeft > 0)
		{
            timeLabel.GetComponent<Text>().text = timeLeft.ToString();
            timeLeft--;
            yield return new WaitForSeconds(1.0f);
        }
        Debug.Log("Time is up");
	}

    // Update is called once per frame
    /*void Update()
    {
        if (timeLeft > 0)
            timeLeft -= Time.deltaTime;
        else
		{
            // Put code here for what happens when time runs out
            timeLeft = 30;
        }


        // The following code makes only the integer portion of timeLeft display
        if (timeLeft < 10)
            timeLabel.GetComponent<Text>().text = timeLeft.ToString().Substring(0, 1);
        else
            timeLabel.GetComponent<Text>().text = timeLeft.ToString().Substring(0, 2);
    }*/
}
