using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float playerSpeed = 10;

    private Animator anim;
    private Vector2 movement;
    private Rigidbody2D rb;
    private Camera cam;
    private Transform rbTransform;
    

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();

        rbTransform = rb.transform;
        anim= GetComponent<Animator>();
        //Change line below once game is really starting
        anim.SetBool("running", true);
    }

    // Update is called once per frame
    void Update()
    {
        movement.y = Input.GetAxisRaw("Vertical");
        movement.x = Input.GetAxisRaw("Horizontal");
        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * playerSpeed * Time.fixedDeltaTime);
    }
}
