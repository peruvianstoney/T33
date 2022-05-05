using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float velocityX = 15f;

    private Rigidbody2D rb;
    private GameController game;
    
    private const string ENEMY_TAG = "Enemy";
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        game = FindObjectOfType<GameController>();
    }

    void Update()
    {
        rb.velocity = new Vector2(velocityX, rb.velocity.y);
        Destroy(this.gameObject,2);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(ENEMY_TAG))
        {
            Destroy(other.gameObject);
            game.PlusScore(5);
            Debug.Log(game.GetScore());
            game.matar();

        }
    }
}
