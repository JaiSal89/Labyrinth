using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public int difficulty = 0;

   public void PlayGame ()
   {
        if ( difficulty == 0)
        {
            SceneManager.LoadScene("Main Scene");
            ScoreTextScript.coinAmount = 0;
        }
        else  if (difficulty == 1)
        {
            SceneManager.LoadScene("Medium");
            ScoreTextScript.coinAmount = 0;
        }
        else if (difficulty == 2)
        {
            SceneManager.LoadScene("Hard");
            ScoreTextScript.coinAmount = 0;
        }

    
   }
    public void Main()
    {
        difficulty = 0;
    }
    public void Medium()
    {
        difficulty = 1;
    }
    public void Hard()
    {
        difficulty = 2;
    }
    public void MenuRetun()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void QuitGame ()
    {
        Debug.Log ("Quit!");
        Application.Quit();
    }
}
