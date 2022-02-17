using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject self;

    private Rigidbody2D rbPlayer;

    public Rigidbody2D rbEnemy;

	private float timeBtwShots;

	public float startTimeBtwShots;

	public GameObject projectile;

    public GameObject muzzleTip;

    private void Start()
    {
        timeBtwShots = startTimeBtwShots;
        rbPlayer = GameObject.Find("Player").GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
        if (GameObject.Find("Player") != null)
        {
            Vector2 target = rbPlayer.position;
            Vector2 self = rbEnemy.position;

            Vector2 lookDir = target - self;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90f;
            rbEnemy.rotation = angle;
            if (timeBtwShots <= 0)
            {
                Instantiate(projectile, muzzleTip.transform.position, Quaternion.identity);
                timeBtwShots = startTimeBtwShots;
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }
        }
        
    }
}
