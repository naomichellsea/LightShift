using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // needs for UI interaction

public class Killzoneobj : MonoBehaviour
{
    // Reference to the animator, death text, and restart button for dragging
    public Animator deathText; 
    public Button restartButton; 

    private void Start()
    {
        // Initially hide the text and button
        deathText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //to check if the object entered the trigger is player 
        if (collision.CompareTag("Player")) 
        {
            // message text on the unity 
            Debug.Log("Player fell into the Kill Zone!");


            // players position resetting 
            collision.transform.position = new Vector3(-8, -2, 0);

            // Display death text and button
            deathText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
        }
        else if (collision.CompareTag("Drone")) // Check if the player hits the drone
        {
            Debug.Log("Player hit the drone!");

           
            RestartLevel(); // Restart the level directly
        }
    }

    public void RestartLevel()
    {
        // Hide death screen elements
        deathText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);

    }

}


