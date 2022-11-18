using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TmpMovePlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //player.transform.position = new Vector3((float)(player.transform.position.x + 0.1), 0); // LE JOUEUR NE BOUGE PAS
    }
}
