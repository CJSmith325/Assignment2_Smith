using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerScript : MonoBehaviour
{
    public string Tag;
    public Rigidbody2D reggiebody;
    public float knockbackForce;
    public float screenShakeIntensity;
    public UnityEngine.Events.UnityEvent OnKnockback;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == Tag)
        {
            Vector2 touchDirection = this.transform.position - other.transform.position;

            reggiebody.AddForce(touchDirection.normalized * knockbackForce);

            OnKnockback.Invoke();
        }
    }
}
