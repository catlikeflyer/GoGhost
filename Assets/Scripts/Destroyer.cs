using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    public float lifetime;

    private void Start()
    {
        // Destoys game objects that are out of scene
        Destroy(gameObject, lifetime);
    }
}
