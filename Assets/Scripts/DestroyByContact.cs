using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;

    void OnCollisionEnter2D(Collision2D other)
    {
        // Instantiate our explosion prefab at the correct location
        Instantiate(explosion, transform.position, transform.rotation);

        // Destroy the "other" object and destroy this asteroid
        Destroy(other.gameObject); // Laser
        Destroy(this.gameObject);
    }
}
