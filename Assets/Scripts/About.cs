using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class About : MonoBehaviour
{
    // MainMenu is index 0
    // Tutorial is index 1
    // GamePlay is index 2
    // TryAgainMenu is index 3
    // GameComplete is index 4
    // Settings is index 5
    // About is index 6
    // PauseMenu is index 7

    // goes back to MainMenu
    public void Back() {
        Debug.Log("About");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }
}
