using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // for loading the scene of the game

public class GameManager : MonoBehaviour
{
    public Animator completionpanel;

    public void LevelCompleted()
    {
        completionpanel.SetTrigger("ShowCompletionPanel");
        
    }

}