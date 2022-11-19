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
        Vector3 pos = Camera.main.WorldToViewportPoint(rbTransform.position);
        if (pos.x >= 0 && pos.x <= 1 && pos.y >= 0 && pos.y <= 1)
        {
            rb.MovePosition(rb.position + movement * playerSpeed * Time.fixedDeltaTime);
        }
        else if (pos.x < 0)
        {
            rb.position = new Vector3(rbTransform.position.x + 0.01f, rbTransform.position.y, rbTransform.position.z);
        }
        else if (pos.x > 1.0)
        {
            rb.position = new Vector3(rbTransform.position.x - 0.01f, rbTransform.position.y, rbTransform.position.z);
        }
        else if (pos.y < 0)
        {
            rb.position = new Vector3(rbTransform.position.x, rbTransform.position.y+0.01f, rbTransform.position.z);
        }
        else if (pos.y > 1.0)
        {
            rb.position = new Vector3(rbTransform.position.x, rbTransform.position.y - 0.01f, rbTransform.position.z);
        }
    }
}
