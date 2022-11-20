using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject cartempty;
    [SerializeField] private GameObject cartfull1;
    [SerializeField] private GameObject cartfull2;
    [SerializeField] private GameObject cartfull3;
    [SerializeField] private GameObject cartfull4;
    [SerializeField] private GameObject cartfull5;
    [SerializeField] private GameObject cartfull6;
    [SerializeField] private GameObject cartfull7;
    [SerializeField] private GameObject cartfull8;
    [SerializeField] private TextMeshProUGUI scoreText;
    public static float itemsCollected = 0;
    // Start is called before the first frame update
    void Start()
    {
        itemsCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = itemsCollected.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("item"))
        {
            if(GameManager.isEndless)
            {
                GameManager.gameOver = true;
            }
            Destroy(collision.gameObject);
            itemsCollected += 50f;
            Debug.Log(itemsCollected);
            float tmpCollected = itemsCollected / 50;
            if(tmpCollected > 0 && tmpCollected < 10)
            {
                cartempty.SetActive(false);
                cartfull1.SetActive(true);
            }
            else if (tmpCollected >= 10 && tmpCollected < 20)
            {
                cartfull1.SetActive(false);
                cartfull2.SetActive(true);
            }
            else if (tmpCollected >= 20 && tmpCollected < 30)
            {
                cartfull2.SetActive(false);
                cartfull3.SetActive(true);
            }
            else if (tmpCollected >= 30 && tmpCollected < 40)
            {
                cartfull3.SetActive(false);
                cartfull4.SetActive(true);
            }
            else if (tmpCollected >= 40 && tmpCollected < 50)
            {
                cartfull4.SetActive(false);
                cartfull5.SetActive(true);
            }
            else if (tmpCollected >= 50 && tmpCollected < 60)
            {
                cartfull5.SetActive(false);
                cartfull6.SetActive(true);
            }
            else if (tmpCollected >= 60 && tmpCollected < 70)
            {
                cartfull6.SetActive(false);
                cartfull7.SetActive(true);
            }
            else
            {
                cartfull7.SetActive(false);
                cartfull8.SetActive(true);
            }
        }
    }
}
