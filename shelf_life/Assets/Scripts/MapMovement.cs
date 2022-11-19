using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMovement : MonoBehaviour
{
    [SerializeField] private GameObject mapTile;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mapTile.transform.position = new Vector3((float)(mapTile.transform.position.x - GameManager.getMovementSpeed()), 0); // LE JOUEUR NE BOUGE PAS
    }
}
