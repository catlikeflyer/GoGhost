using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public int score;
    public int level;
    public Text scoreDisplay;

    private void Update()
    {
        // Shows score and level on string
        scoreDisplay.text = score.ToString() + " - Level " + level.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        // For every 10 points level goes up 
        if (score%10 == 0)
        {
            level++;
        }

        Destroy(other.gameObject);
    }
}
