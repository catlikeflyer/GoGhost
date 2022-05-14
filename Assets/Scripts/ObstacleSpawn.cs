using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour {

    public GameObject obstacle; // Takes on obstacle to be created

    private void Start()
    {
        // Creates new obstacle wave
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }
}
