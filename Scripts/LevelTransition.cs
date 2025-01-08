using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

// This script handles the transition to the next level when the player reaches the window.
public class LevelTransition : MonoBehaviour
{
    // This method is called when another collider enters the trigger collider of this object.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player reached the window. Loading next level...");

            SceneManager.LoadScene("Level 2"); //loads the level 2
        }
    }
}
