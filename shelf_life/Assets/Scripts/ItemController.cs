using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    [SerializeField] private GameObject itemPane;
    [SerializeField] private GameObject roadPane;
    private Transform roadTransform;
    private int objectCounter = 10;
    private float randomX;
    private float randomY;
    private float paneWidth;
    private float paneHeight;
    private Queue<GameObject> itemQueue;
    private int itemsCollected = 0;
    // Start is called before the first frame update
    void Start()
    {
        itemQueue = new Queue<GameObject>();
        paneWidth = roadPane.GetComponent<SpriteRenderer>().bounds.size.x;
        paneHeight = roadPane.GetComponent<SpriteRenderer>().bounds.size.y;
        for (int i = 0; i < objectCounter; i++)
        {
            randomX = 3 * paneWidth + UnityEngine.Random.Range(-paneWidth, paneWidth);
            randomY = UnityEngine.Random.Range(-paneHeight / 4, paneHeight / 4);
            GameObject item;
            item = GameObject.Instantiate(itemPane);

            item.transform.parent = roadTransform;
            item.tag = "item";
            item.transform.position = new Vector3(randomX, randomY, -1f);

            itemQueue.Enqueue(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(itemQueue.Peek().transform.position.x) > Math.Abs(paneWidth / 2)) // If first pane gets too far from player chain it to the front
        {
            randomX = paneWidth + UnityEngine.Random.Range(-paneWidth / 2, paneWidth / 2);
            randomY = UnityEngine.Random.Range(-paneHeight / 4, paneHeight / 4);
            GameObject loopedRoad = itemQueue.Dequeue();
            loopedRoad.transform.position = new Vector3(randomX, randomY, -1f);
            itemQueue.Enqueue(loopedRoad);
        }
    }

    private void updateRandomPos()
    {
        randomX = paneWidth + UnityEngine.Random.Range(-40, 40);
        randomY = UnityEngine.Random.Range(-paneHeight / 4, paneHeight / 4);
    }
}
