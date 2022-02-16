using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    PlayerLives playerLives;

    public float speed;

    private Transform player;

    private Vector2 target;
    private void Awake()
    {
        playerLives = GameObject.Find("Environment").GetComponent<PlayerLives>();

        
    }

    private void Start()
    {
        if (GameObject.Find("Player") != null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;

            target = new Vector2(player.position.x, player.position.y);
        }
        //player = GameObject.FindGameObjectWithTag("Player").transform;
        
        //target = new Vector2(player.position.x, player.position.y);
        
    }

    private void Update()
    {
       
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
            
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DestroyProjectile();
            playerLives.playerLives = playerLives.playerLives - 1;
            Debug.Log(playerLives.playerLives);
            if (playerLives.playerLives == 0)
            {
                Destroy(collision.gameObject);
            }
        }
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
        
    }
}
