using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float playerSpeed = 10;
    private Vector2 movement;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.y = Input.GetAxisRaw("Vertical");
        movement.x = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position+ movement * playerSpeed * Time.fixedDeltaTime);
    }
}
