using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainMenu : MonoBehaviour
{
    // MainMenu is index 0
    // scene1 is index 1
    // scene2 is index 2
    // scene3 is index 3
    // GameComplete is index 4
    
    // go to gameplay
    public void TryAgain() 
    {
        Debug.Log("Try Again");
        // TODO
    }

    public void MainMenu() 
    {
        SceneManager.LoadScene("MainManu");
    }

    public void QuitGame() 
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
