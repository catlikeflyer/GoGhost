using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    public float speed; // Speed of enemy colliders
    public GameObject effect; // Enemy effect on impact

    // Moves enemies
	void Update () {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            other.GetComponent<Player>().health--; // If player hits it, health decreases
            other.GetComponent<Player>().camAnim.SetTrigger("shake"); // Player shaking animation when hit
            Instantiate(effect, transform.position, Quaternion.identity); // Blasting effect
            Destroy(gameObject); // Destroys after it goes out
        }   
    }
}
