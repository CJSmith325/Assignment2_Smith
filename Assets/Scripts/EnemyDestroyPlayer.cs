using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class EnemyDestroyPlayer : MonoBehaviour
{
    PlayerLives playerLives;
    private void Awake()
    {
        playerLives = GameObject.Find("Environment").GetComponent<PlayerLives>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            playerLives.playerLives = playerLives.playerLives - 1;
            Debug.Log(playerLives.playerLives);
            if (playerLives.playerLives == 0)
            {
                Destroy(collision.gameObject);
            }
        }
    }


}
