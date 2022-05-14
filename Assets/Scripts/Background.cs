using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public float speed;  // Bg parallax speed
    public float Xend; // X position where bg destroys
    public float Xstart; // X position where bg inits

    private void Update()
    {
        // Start bg movement
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        // Update bg pos if between x start and end
        if (transform.position.x < Xend) {
            Vector2 pos = new Vector2(Xstart, transform.position.y);
            transform.position = pos;
        } 
    }
}
