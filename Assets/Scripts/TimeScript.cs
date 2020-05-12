using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour
{
    public Text timeLabel;
    public Text timeAddedText;
    public static bool incrementTime;
    int timeLeft;

    void Start()
    {
        incrementTime = false;
        timeLeft = 40;
        StartCoroutine(countdown());
    }

    void Update()
	{
        if (incrementTime)
		{
            // incrementTime becomes true when a bullet hits a monster
            incrementTime = false;
            timeLeft++;
            StartCoroutine(showTimeAddedText());
		}
	}

    public IEnumerator countdown()
	{
        while (timeLeft > 0)
		{
            timeLabel.GetComponent<Text>().text = timeLeft.ToString();
            timeLeft--;
            yield return new WaitForSeconds(1);
        }
        SceneManager.LoadScene("NewHighScore");
	}

    IEnumerator showTimeAddedText()
    {
        // Show "+ 1 second" at the top of the screen for 1 second
        timeAddedText.enabled = true;
        yield return new WaitForSeconds(1);
        timeAddedText.enabled = false;
    }

    public void endGame()
	{
        timeLeft = 0;
	}
}
