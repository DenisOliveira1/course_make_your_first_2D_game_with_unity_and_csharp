using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
       float input = Input.GetAxisRaw("Horizontal");
       print(input);

       rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }
}
