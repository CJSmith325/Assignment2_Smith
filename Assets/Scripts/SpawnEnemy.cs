using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    float randX;
    float randY;
    Vector2 spawnPoint;
    public float spawnRate = 1f;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player") != null)
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                randX = Random.Range(-7.43f, 8.91f);
                randY = Random.Range(-5.45f, 3.2f);
                spawnPoint = new Vector2(randX, randY);
                Instantiate(enemy1, spawnPoint, Quaternion.identity);
                //repeat for other enemy prefab
                randX = Random.Range(-7.43f, 8.91f);
                randY = Random.Range(-5.45f, 3.2f);
                spawnPoint = new Vector2(randX, randY);
                Instantiate(enemy2, spawnPoint, Quaternion.identity);
            }
        }
    }
}
