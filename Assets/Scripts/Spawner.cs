using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    private float timeBtwSpawns; 
    public float startTimeBtwSpawns;
    public float timeDecrease;
    public float minTime; // Minimum time between spawns for the game to be playable

    public GameObject[] obstacleTemplate;

    private void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }

    private void Update()
    {
        // When spawn timer reaches 0
        if (timeBtwSpawns <= 0)
        {
            // Randomly spawns a wave of obstacles: 2 obstacles and one place for the player
            int rand = Random.Range(0, obstacleTemplate.Length);
            Instantiate(obstacleTemplate[rand], transform.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;

            // Spawning times decrease as player progresses.
            if (startTimeBtwSpawns > minTime) {
                startTimeBtwSpawns -= timeDecrease;
            }
        }
        else {
            // Reduces the time between each wave as player keeps playing
            timeBtwSpawns -= Time.deltaTime;
        }
    }

}
