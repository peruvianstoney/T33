using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocityX = 5;
    private const int LAYER_GROUND = 6;
    public bool jump = false;
    public bool vel = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (vel == true)
        rb.velocity = new Vector3(-velocityX,rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if( jump == true && vel == false)
        {
            if (collision.gameObject.layer == LAYER_GROUND)
            {
            rb.velocity = new Vector2(rb.velocity.x, 5);
            }
        }
    }
}
