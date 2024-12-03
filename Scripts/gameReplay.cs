using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameReplay : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        scoreControl.score = 0;
        hpControl.hp = 10;
        keyControl.key = 0;
        playerCollider.finish = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void toMenu()
    {
        SceneManager.LoadScene("New Scene");
    }
}
