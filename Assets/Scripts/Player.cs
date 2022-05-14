using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This acts as the principal scene
public class Player : MonoBehaviour {

    public float speed; // Player speed
    public float increment; // Speed increment as level increases
    public float maxY; // Scene delimiter bottom
    public float minY; // Scene delimiter top

    private Vector2 targetPos; // Position movement up or down

    public int health; 

    public GameObject moveEffect; // Ghost moving animation
    public Animator camAnim; // Camera shaking animation
    public Text healthDisplay; // Health numbers

    public GameObject spawner; // Spawns wave of obstacles
    public GameObject restartDisplay; // If user restarts, resets screen

    private void Update()
    {
        // If player has no health, destroyed
        if (health <= 0) {
            spawner.SetActive(false);
            restartDisplay.SetActive(true);
            Destroy(gameObject);
        }

        healthDisplay.text = health.ToString() + " lives"; // Display health numbers

    transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime); // move between the three positons, up and down

        // Move player up and animate
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY) {
            camAnim.SetTrigger("shake");
            Instantiate(moveEffect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + increment);
        } 
        // Move player down and animate
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY) {
            camAnim.SetTrigger("shake");
            Instantiate(moveEffect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
        }
    }
}
