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

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        

        playerLives.playerLives = playerLives.playerLives - 1;
        if (playerLives.playerLives == 0)
        {
            Destroy(other.gameObject);
        }
        Debug.Log(playerLives.playerLives);
    }
}
