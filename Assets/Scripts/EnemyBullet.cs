using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    PlayerLives playerLives;
    private void Awake()
    {
        playerLives = GameObject.Find("Environment").GetComponent<PlayerLives>();

        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerLives.playerLives = playerLives.playerLives - 1;
        }
        Destroy(this.gameObject);
        if (playerLives.playerLives == 0)
        {
            Destroy(other.gameObject);
        }
        Debug.Log(playerLives.playerLives);
    }
}
