using System.Collections;
using System.Collections.Generic;
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
    private float itemsCollected = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("item"))
        {
            Destroy(collision.gameObject);
            itemsCollected += 0.5f;
            Debug.Log(itemsCollected);

            if(itemsCollected > 0 && itemsCollected < 10)
            {
                cartempty.SetActive(false);
                cartfull1.SetActive(true);
            }
            else if (itemsCollected >= 10 && itemsCollected < 20)
            {
                cartfull1.SetActive(false);
                cartfull2.SetActive(true);
            }
            else if (itemsCollected >= 20 && itemsCollected < 30)
            {
                cartfull2.SetActive(false);
                cartfull3.SetActive(true);
            }
            else if (itemsCollected >= 30 && itemsCollected < 40)
            {
                cartfull3.SetActive(false);
                cartfull4.SetActive(true);
            }
            else if (itemsCollected >= 40 && itemsCollected < 50)
            {
                cartfull4.SetActive(false);
                cartfull5.SetActive(true);
            }
            else if (itemsCollected >= 50 && itemsCollected < 60)
            {
                cartfull5.SetActive(false);
                cartfull6.SetActive(true);
            }
            else if (itemsCollected >= 60 && itemsCollected < 70)
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

    public void loadFinalCutscene()
    {
        if (itemsCollected < 10)
        {
            SceneManager.LoadScene("ending_one"); // TODO: Changer le nom
        }
        else
        {
            SceneManager.LoadScene("ending_two"); // TODO: Changer le nom
        }
    }
}
