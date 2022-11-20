using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MapGen : MonoBehaviour
{
    [SerializeField] private GameObject mapPane;
    [SerializeField] private GameObject player;
    private Transform roadTransform;
    //private List<GameObject> roads = new List<GameObject>();
    private Queue<GameObject> roadQueue;
    private int interval = 60;
    private float paneWidth;
    // Start is called before the first frame update
    private int cpt = 0;
    void Start()
    {
        paneWidth = mapPane.GetComponent<SpriteRenderer>().bounds.size.x;
        roadQueue = new Queue<GameObject>();
        roadTransform = GameObject.Find("Road").transform;
        for (int i = 0; i < 5; i++)
        {
            GameObject map;
            map = GameObject.Instantiate(mapPane);

            map.transform.parent = roadTransform;
            map.tag = "road";
            map.transform.position = new Vector3(paneWidth * i, 0, 0f);
            
            roadQueue.Enqueue(map);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(roadQueue.Peek().transform.position.x) > Math.Abs(paneWidth)) // If first pane gets too far from player chain it to the front
        {
            GameObject loopedRoad = roadQueue.Dequeue();
            loopedRoad.transform.position = new Vector3(loopedRoad.transform.position.x + paneWidth * (roadQueue.Count + 1), 0, 0f);
            roadQueue.Enqueue(loopedRoad);
        }
    }
}
