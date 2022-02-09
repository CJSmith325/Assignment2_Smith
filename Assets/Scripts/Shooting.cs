using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float bulletLife;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public AudioClip audioClip;
    private AudioSource audioSource; //The thing to play the audio

    public float bulletForce = 20f;

    void PlayShootingSound()
    {
        
        //If you need to change the volume
        //audioSource.volume = volume;
        //Play the sound once
        audioSource.PlayOneShot(audioClip);


       
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioClip = GetComponent<AudioClip>();
        if (audioSource == null)
        {
            Debug.LogError("No AudioSource found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            PlayShootingSound();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet, bulletLife);
    }
}
