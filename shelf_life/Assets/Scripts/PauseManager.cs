using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            GameManager.setMovementSpeedTo0();
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
        }
    }

    public void Resume()
    {
        GameManager.setMovementSpeedBack();
        Time.timeScale = 1.0f;
        pauseMenu.SetActive(false);
    }

    public void BackToMenu()
    {
        GameManager.setMovementSpeedBack();
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();

    }
}
