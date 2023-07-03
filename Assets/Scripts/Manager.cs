using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPaused;
    public bool isStarted;
    public bool isEnd;
    public int restart;
    public int scorePlayer1;
    public int scorePlayer2;
    public GameObject startScreen;
    public GameObject pauseScreen;
    public GameObject gameScreen;
    public GameObject endScreen;
    public GameObject score;
    public GameObject ball;
    void Start()
    {
        isPaused = false;
        PausePhysics(true);
        isStarted = false;
        isEnd = false;
        scorePlayer1 = 0;
        scorePlayer2 = 0;
        restart = 1;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (restart != 0)
        {
            ball.GetComponent<Transform>().localPosition = new Vector3(0, 0, 0);
            ball.GetComponent<Rigidbody2D>().velocity = (new Vector3(Random.Range(1, 3) * Random.Range(-2, -1) * Random.Range(-2, -1), Random.Range(1, 3) * Random.Range(-2, -1) * Random.Range(-2, -1), 0));
            restart = 0;
        }
    }

    void Update()
    {
        
        if (isStarted)
        {
            startScreen.SetActive(false);
            gameScreen.SetActive(true);
        }
        else
        {
            scorePlayer1 = 0;
            scorePlayer2 = 0;
            startScreen.SetActive(true);
            gameScreen.SetActive(false);
        }

        if (isPaused)
        {
            PausePhysics(true);
            pauseScreen.SetActive(true);
        }
        else
        {
            pauseScreen.SetActive(false);
        }

        if (isEnd)
        {
            endScreen.SetActive(true);
        }
        else
        {
            endScreen.SetActive(false);
        }

        score.GetComponent<TMP_Text>().text = scorePlayer1 + "-" + scorePlayer2;
    }

    public void PausePhysics(bool isPaused)
    {
        Time.timeScale = isPaused ? 0 : 1;
    }
}
