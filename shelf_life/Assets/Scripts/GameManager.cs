using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isEndless;
    public static bool gameOver = false;
    private static float MOVEMENT_SPEED = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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
        Application.targetFrameRate = 60;
    }
}
