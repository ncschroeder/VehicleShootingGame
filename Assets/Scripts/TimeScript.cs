using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public Text timeLabel;
    void Start()
    {
        StartCoroutine(countdown());
    }

    public IEnumerator countdown()
	{
        int timeLeft = 20;
        while (timeLeft > 0)
		{
            timeLabel.GetComponent<Text>().text = timeLeft.ToString();
            timeLeft--;
            yield return new WaitForSeconds(1.0f);
        }
	}
}
