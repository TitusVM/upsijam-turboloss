using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static float MOVEMENT_SPEED = 0.1f;

    [SerializeField] private AudioSource click;

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

    void Awake()
    {
        QualitySettings.vSyncCount = 0;  // VSync must be disabled
        Application.targetFrameRate = 60;
    }
    public void OnClick()
    {
        Debug.Log("Click");
        click.Play();
    }

}
