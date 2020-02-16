using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainMenu : MonoBehaviour
{
    // MainMenu is index 0
    // Tutorial is index 1
    // GamePlay is index 2
    // TryAgainMenu is index 3
    // GameComplete is index 4
    // Settings is index 5
    // About is index 6
    // PauseMenu is index 7
    
    // go to gameplay
    public void TryAgain() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Tutorial() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void MainMenu() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void QuitGame() 
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
