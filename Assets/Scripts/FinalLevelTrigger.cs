using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalLevelHandler : MonoBehaviour
{
    public GameObject textAndButtonUI; // text and button for UI Design

    private void Start() 
    {
        // hide the UI Design at the start of the game
        textAndButtonUI.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)  // Parameter is 'collision'
    {
        if (collision.CompareTag("Player")) // makes sure its the player on tag
        {
            Debug.Log("Player entered trigger zone!");  // confirmimg if the trigger is working
            textAndButtonUI.SetActive(true);
        }
    }

    public void OnButtonClick()
    {
        // loads the first scene depends on your build setting number (1)
        SceneManager.LoadScene(0);
    }
}
