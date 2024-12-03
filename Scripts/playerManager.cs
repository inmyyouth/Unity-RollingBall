using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public GameObject finishPanel;
    public GameObject basicPanel;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        gameOverPanel.SetActive(false);
        finishPanel.SetActive(false);
        basicPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (hpControl.hp <= 0)
        {
            gameOver = true;
        }

        if(!gameOver & playerCollider.finish)
        {
            finishPanel.SetActive(true);
            basicPanel.SetActive(false);
        }

        if (gameOver)
        {
            if (playerCollider.finish)
            {
                //finishPanel.SetActive(false);
                basicPanel.SetActive(false);
            }
            else
            {
                gameOverPanel.SetActive(true);
                basicPanel.SetActive(false);
            }
        }
    }
}
