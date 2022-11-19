using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
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
        if (collision.gameObject.tag.Equals("Item"))
        {
            Destroy(collision.gameObject);
            itemsCollected++;
            Debug.Log(itemsCollected);
        }
    }

    public int GetItemsCollected()
    {
        return this.itemsCollected;
    }
}
