using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Pause System


// Pausing the game by pressing the space key
// Create a new cSharp script called Pause
// Attach the script to the main camera



public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject pauseMenu;


    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (isPaused)
            {
                
                Resume();
                
            }

            // note 0.5 = half speed, 2.5f slowed down version

            else
            {   
                Pause();

            }
        }

    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;

    }

    void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;

    }

    public void LoadMenu()
    {
        Time.timeScale = 1f; // adjusts time back
        SceneManager.LoadScene("Menu");

    }

    public void QuitGame()
    {
        Debug.Log("Closing Game"); // This is used to inform the develeoper whats happening as game wont close in editor.
        Application.Quit();
    }


}

    
