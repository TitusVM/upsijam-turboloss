using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float timeValue = 30;
    public TextMeshProUGUI timeText;


    // Update is called once per frame
    void Update()
    {
        if(timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
            if (Player.itemsCollected < 10)
            {
                SceneManager.LoadScene("Game"); // TODO: Changer le nom
            }
            else
            {
                SceneManager.LoadScene("MainMenu"); // TODO: Changer le nom
            }
        }

        displayTime(timeValue);
    }

    void displayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0 ) 
        {
            timeToDisplay= 0;
        }
        else if (timeToDisplay > 0)
        {
            timeToDisplay += 1;
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay% 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
