using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    [SerializeField] private GameObject itemPane;
    [SerializeField] private GameObject roadPane;

    private Transform roadTransform;
    private int objectCounter = 5;
    private float randomX;
    private float randomY;
    private float paneWidth;
    private float paneHeight;
    private List<GameObject> itemList;

    private float increaseDiffEveryXSeconds = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        itemList = new List<GameObject>();
        paneWidth = roadPane.GetComponent<SpriteRenderer>().bounds.size.x;
        paneHeight = roadPane.GetComponent<SpriteRenderer>().bounds.size.y;
        for(int i = 0; i < objectCounter; i++)
        {
            CreateItem();
        }
    }

    // Update is called once per frame
    void Update()
     {
        List<GameObject> newList = new List<GameObject>();
        foreach (GameObject item in itemList)
        {
            if(item != null)
            {
                newList.Add(item);
            }
        }
        
        itemList = newList;

        while (itemList.Count < objectCounter)
        {
            CreateItem();
        }

        foreach (GameObject item in itemList)
        {
            if (IsOutOfScreen(item))
            {
                Destroy(item);
            }
        }
        increaseDiffEveryXSeconds -= Time.deltaTime;
        if (increaseDiffEveryXSeconds <= 0.0f)
        {
            increaseDiffEveryXSeconds = 10.0f;
            objectCounter += 5;
        }
    }

    public bool IsOutOfScreen(GameObject item)
    {
        return item.transform.position.x < -paneWidth;
    }

    private void updateRandomPos()
    {
        randomX = paneWidth + UnityEngine.Random.Range(-40, 40);
        randomY = UnityEngine.Random.Range(-paneHeight / 4, paneHeight / 4);
    }

    private void CreateItem(int i = -1)
    {
        updateRandomPos();
        randomX = 3 * paneWidth + UnityEngine.Random.Range(-paneWidth, paneWidth);
        randomY = UnityEngine.Random.Range(-paneHeight / 4, paneHeight / 4);
        GameObject item = GameObject.Instantiate(itemPane);

        item.transform.parent = roadTransform;
        item.tag = "Item";
        item.transform.position = new Vector3(randomX, randomY, -1f);

        if(i != -1)
        {
            itemList[i] = item;
        }
        else
        {
            itemList.Add(item);
        }
        
    }
}
