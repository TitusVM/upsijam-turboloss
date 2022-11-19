using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private GameObject item;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        item.transform.position = new Vector3((float)(item.transform.position.x - 0.1), item.transform.position.y, item.transform.position.z);
    }

    public void OnCollisionEnter2D(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            
        }
    }
}
