using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 0;
    public bool timeIsRunning = true;
    public TMP_Text timeText;
    public TMP_Text objective;
    string spillClean = "Clean All 5 Spills Quick!";
    string pickup = "Pick Up 4 Mayo Jars!";
    string odor = "Cleanse 8 BO Clouds!";
    // Start is called before the first frame update
    void Start()
    {
        timeIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeIsRunning)
        {
            if (timeRemaining >= 0)
            {
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining);
            }
        }

        if(timeRemaining >= 180)
        {
            SceneManager.LoadScene(1);
        }

        if (timeRemaining >= 0 && timeRemaining <= 60)
        {
            objective.text = spillClean;
            objective.color = Color.yellow;
        }
        else if (timeRemaining >= 61 && timeRemaining <= 120)
        {
            objective.text = pickup;
            objective.color = Color.yellow;

        }
        else if (timeRemaining >= 121 && timeRemaining <= 180)
        {
            objective.text = odor;
            objective.color = Color.yellow;

        }
    }
    void DisplayTime (float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
