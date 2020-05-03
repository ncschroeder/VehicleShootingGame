using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour
{
    public Text timeLabel;
    public static int timeLeft;
    void Start()
    {
        timeLeft = 40;
        StartCoroutine(countdown());
    }

    public IEnumerator countdown()
	{
        while (timeLeft > 0)
		{
            timeLabel.GetComponent<Text>().text = timeLeft.ToString();
            timeLeft--;
            yield return new WaitForSeconds(1.0f);
        }
        SceneManager.LoadScene("NewHighScore");
	}

}
