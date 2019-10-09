using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // FixedUpdate is used when manipulating physics
    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        // Debug.Log("Horizontal: " + horiz + " Vertical: " + vert);

        // Modify players velocity through the rigidbody2D
        Rigidbody2D rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = new Vector2(horiz * speed, vert * speed);
    }
}
