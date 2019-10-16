using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Public variables
    public float speed;
    public GameObject laser;
    public Transform laserSpawn;
    public float fireRate = 0.5f;

    public Vector2 bottomLeftBoundary;
    public Vector2 topRightBoundary;

    // Private variables
    private Rigidbody2D rBody;
    private float counter = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        counter += Time.deltaTime;

        if(Input.GetButton("Fire1") && counter > fireRate)
        {
            // Create and position my laser object
            Instantiate(laser, laserSpawn.position, laser.transform.rotation);
            counter = 0.0f;
        }
    }

    // Update is called once per frame
    // FixedUpdate is used when manipulating physics
    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        // Debug.Log("Horizontal: " + horiz + " Vertical: " + vert);

        // Modify players velocity through the rigidbody2D
        
        rBody.velocity = new Vector2(horiz * speed, vert * speed);

        // Restrict the player from leaving the play area
        rBody.position = new Vector2(
            Mathf.Clamp(rBody.position.x, bottomLeftBoundary.x, topRightBoundary.x),
            Mathf.Clamp(rBody.position.y, bottomLeftBoundary.y, topRightBoundary.y));
    }
}
