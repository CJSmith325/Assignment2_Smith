using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public float bulletLife;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 6.5f;
    public float fireRate = 3000f;
    private float shootingTime;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            
        }
    }



    void Shoot()
    {
        if (Time.time > shootingTime)
        {
            shootingTime = Time.time + fireRate / 1000;
            Vector2 myPos = new Vector2(firePoint.position.x, firePoint.position.y);
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

            Destroy(bullet, bulletLife);
        }
    }
}
