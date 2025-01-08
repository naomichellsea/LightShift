using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject startUI; // Assign the UI elements (text and button)

    public void DisableUI()
    {
        startUI.SetActive(false); // Disable the UI GameObject
    }
}

