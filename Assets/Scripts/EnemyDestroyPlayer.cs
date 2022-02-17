using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDestroyPlayer : MonoBehaviour
{
    PlayerLives playerLives;
    public string sceneName;

    private IEnumerator WaitForSceneLoad(string name)
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(name);

    }

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
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }


}
