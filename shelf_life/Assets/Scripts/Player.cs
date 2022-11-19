using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject cartempty;
    [SerializeField] private GameObject cartfull1;
    [SerializeField] private GameObject cartfull2;
    [SerializeField] private GameObject cartfull3;
    private int itemsCollected = 0;
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
            itemsCollected++;
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
            else
            {
                cartfull2.SetActive(false);
                cartfull3.SetActive(true);
            }
        }
    }

    public int GetItemsCollected()
    {
        return this.itemsCollected;
    }
}
