using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //both of these will be assigned to their corrsponding buttons on the on click function

    //Tell the scene manager to load level 1
   public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    //Quit the app
    public void QuitGame() 
    {
        Application.Quit();
    }
}
