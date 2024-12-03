using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static bool howto = false;

     public void PlayGame()
     {
        SceneManager.LoadScene("SampleScene");
        scoreControl.score = 0;
        hpControl.hp = 10;
        keyControl.key = 0;
        playerCollider.finish = false;
        playerManager.gameOver = false;
    }

     public void howToButton()
    {
        SceneManager.LoadScene("howtoScene");
    }

    public void quitGame()
    {
        Application.Quit();
    }
    
}
