using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform target; //where we want to shoot(player? mouse?)
    public Transform weaponMuzzle; //The empty game object which will be our weapon muzzle to shoot from
    public GameObject bullet; //Your set-up prefab
    public float fireRate = 3f; //Fire every 3 seconds
    public float shootingPower = 20f; //force of projection


    private float shootingTime; //local to store last time we shot so we can make sure its done every 3s

    //public int health = 100;
    public GameObject deathEffect;

    private void Update()
    {
        Fire(); //Constantly fire
    }

    private void Fire()
    {
        if (Time.time > shootingTime)
        {
            shootingTime = Time.time + fireRate; //set the local var. to current time of shooting
            Vector3 myPos = new Vector2(weaponMuzzle.position.x, weaponMuzzle.position.y); //our curr position is where our muzzle points
            GameObject projectile = Instantiate(bullet, myPos, Quaternion.identity); //create our bullet
            Vector3 direction = myPos - (Vector3)target.position; //get the direction to the target
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(weaponMuzzle.up * shootingPower, ForceMode2D.Impulse);
            //projectile.GetComponent<Rigidbody2D>().velocity = direction * shootingPower; //shoot the bullet
        }
    }

    //public void TakeDamage(int damage)
    //{
    //    health -= damage;

    //    if (health <= 0)
    //    {
    //        Die();
    //    }
    //}

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
