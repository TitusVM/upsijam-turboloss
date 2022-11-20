using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextScene()
    {
        GameManager.isEndless= false;
        GameManager.gameOver= false;
        SceneManager.LoadScene("Game");
    }
    public void loadEndless()
    {
        GameManager.isEndless = true;
        GameManager.gameOver = false;
        SceneManager.LoadScene("Endless");
    }
}
