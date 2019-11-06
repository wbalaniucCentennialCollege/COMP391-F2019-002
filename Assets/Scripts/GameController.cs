using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Control the spawn of hazards
    [Header("Wave Settings")]
    public GameObject hazard;   // What are we spawning?
    public Vector2 spawnValue;  // Where do we spawn our hazards?
    public int hazardCount;     // How many hazards per wave?
    public float startWait;     // How long until the first wave?
    public float spawnWait;     // How long between each hazard in a wave?
    public float waveWait;      // How long between each wave?

    // Player Score
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Create a coroutine function
    IEnumerator SpawnWaves()
    {
        // Delay the first wave by a period of time
        yield return new WaitForSeconds(startWait); // Wait for "startWait" seconds

        while(true) // Now the game starts
        {
            for(int i = 0; i < hazardCount; i++)
            {
                Vector2 spawnPosition = new Vector2(spawnValue.x, Random.Range(-spawnValue.y, spawnValue.y));

                Instantiate(hazard, spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(0, spawnWait));
            }
            yield return new WaitForSeconds(waveWait);
            hazardCount++;
        }
    }
}
