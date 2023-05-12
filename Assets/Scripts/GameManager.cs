using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Slider progressBar;
    private bool gamePaused;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        gamePaused = false;
        progressBar = GameObject.Find("ProgressBar").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(!gamePaused)
        {
            progressBar.value += (0.1f * 0.01f);
            if(progressBar.value >= progressBar.maxValue)
            {
                Time.timeScale = 0;
                gamePaused = true;
            }
        }
    }
}
