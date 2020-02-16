using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedMenu1 : MonoBehaviour
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
    
    [SerializeField] private GameObject pauseMenuUI;
    
    [SerializeField] private bool isPaused;

    private void Update()
    {
        // press escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            ActivateMenu();
        }

        else
        {
            DeactivateMenu();
        }
    }

    void ActivateMenu()
    {   
        Time.timeScale = 0; // stops time
        AudioListener.pause = true;
        pauseMenuUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1; // time is normal time
        AudioListener.pause = false;
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }

    public void RestartLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        isPaused = false;
    }

    public void MainMenu() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        isPaused = false;
    }

    public void QuitGame() 
    {
        isPaused = false;
        Debug.Log("Quit!");
        Application.Quit();
    }
}
