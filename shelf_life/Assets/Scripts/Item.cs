using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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
        item.transform.position = new Vector3((float)(item.transform.position.x - GameManager.getMovementSpeed()), item.transform.position.y, item.transform.position.z);
    }
}
