using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryDestoryer : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D other)
    {
        Destroy(other.gameObject); // Destroy the entire game object
    }
}
