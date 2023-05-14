using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Slider progressBar;
    private bool gamePaused;

    public GameObject gameOverScreen;
    public GameObject winScreen;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        gamePaused = false;
        progressBar = GameObject.Find("ProgressBar").GetComponent<Slider>();
    }

    private void FixedUpdate()
    {
        if(!gamePaused)
        {
            progressBar.value += (0.05f * 0.01f);
            if(progressBar.value >= progressBar.maxValue)
            {
                GameWon();
            }
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gamePaused = true;
        gameOverScreen.SetActive(true);
    }

    public void GameWon()
    {
        Time.timeScale = 0;
        gamePaused = true;
        winScreen.SetActive(true);
    }
}
