using UnityEngine;
using UnityEngine.UI;  // For UI components
using UnityEngine.SceneManagement;  // For loading scenes

public class LevelCompletion : MonoBehaviour
{
    // for dragging in the unity
    public Animator playerAnimator; 
    public Text completionText; 
    public Button restartButton; 

    private void Start()
    {
       
        completionText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
    }

    // This function will be called when the level is completed
    public void CompleteLevel()
    {
        //triggers the level animaion
        if (playerAnimator != null)
        {
            playerAnimator.SetTrigger("LevelComplete"); 
        }

        // Display the completion text and restart button
        completionText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    // This function will be called when the restart button is clicked
    public void RestartGame()
    {
        // Reload the current level the player is on
        SceneManager.LoadScene(0); 
    }
}
