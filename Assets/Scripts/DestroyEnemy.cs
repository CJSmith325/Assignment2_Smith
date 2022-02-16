using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    private float playerLives = 3f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        playerLives = playerLives - 1;
        if (playerLives == 0)
        {
            Destroy(this.gameObject);
        }
        Debug.Log(playerLives);
    }
}
