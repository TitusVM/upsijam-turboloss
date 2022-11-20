using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerIncrement : MonoBehaviour
{

    public float timeValue = 30;
    public TextMeshProUGUI timeText;
    public GameObject gameOverPanel;
    public GameObject deadPlayer;
    // Start is called before the first frame update
    void Update()
    {
        if(GameManager.gameOver)
        {
            gameOverPanel.SetActive(true);
            deadPlayer.SetActive(true);
        }

        timeValue += Time.deltaTime;
        

        displayTime(timeValue);
    }

    void displayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
