using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    [SerializeField] float time;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyCoroutine(time));
    }

    IEnumerator MyCoroutine(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay
        Debug.Log("coucou");
        SceneManager.LoadScene("MainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
