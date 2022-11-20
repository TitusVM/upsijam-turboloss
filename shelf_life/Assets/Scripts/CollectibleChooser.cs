using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleChooser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<GameObject> children = new List<GameObject>();

        foreach(Transform child in this.transform)
        {
            children.Add(child.gameObject);
        }
        int random = UnityEngine.Random.Range(0, children.Count - 1);

        children[random].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
