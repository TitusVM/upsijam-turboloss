using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool isEndless;
    public static bool gameOver = false;
    private static float MOVEMENT_SPEED = 0.1f;
    public static bool finishedGameOnce = false;

    [SerializeField] private AudioSource click;
    public Button endlessBtn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(finishedGameOnce)
        {
            endlessBtn.interactable = true;
        }
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
        
    }

    public static float getMovementSpeed()
    {
        return MOVEMENT_SPEED;
    }

    public static void setMovementSpeedTo0()
    {
        MOVEMENT_SPEED = 0.0f;
    }
    public static void setMovementSpeedBack()
    {
        MOVEMENT_SPEED= 0.1f;
    }
    void Awake()
    {
        QualitySettings.vSyncCount = 0;  // VSync must be disabled
        Application.targetFrameRate = 59;
    }
    public void OnClick()
    {
        Debug.Log("Click");
        click.Play();
    }

}
