using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour {

    public void PlayGame ()

    {
        // In conjunction with the build settings this will load the next page in the index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);

    }

    public void QuitGame ()
    {
        Debug.Log("Quit!");
        // This will quit the Game
       Application.Quit ();

    }
   }
