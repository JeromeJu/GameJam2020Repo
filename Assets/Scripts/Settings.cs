using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    // MainMenu is index 0
    // Tutorial is index 1
    // Scene1 is index 2
    // TryAgainMenu is index 3
    // GameComplete is index 4
    // Settings is index 5
    // About is index 6
    // Scene2 is index 7
    // Scene3 is index 8

    // goes back to MainMenu
    public void Back() {
        Debug.Log("Back to Main Menu");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
}
