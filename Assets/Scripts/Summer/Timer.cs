using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timer;
    public int score;
    public static bool gameOver;
    [SerializeField] TMP_Text timeText;
    [SerializeField] TMP_Text scoreText;
    float minutes = 0;
    float seconds = 0;
    private void Start()
    {
        score = 0;
        gameOver = false;
    }

    private void Update()
    {
        CountDown();
    }

    private void CountDown()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;

            minutes = Mathf.FloorToInt(timer / 60);
            seconds = Mathf.FloorToInt(timer % 60);

        }
        else
        {
            minutes = 0;
            seconds = 0;
            gameOver = true;
        }
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void AddScore(int s)
    {
        score += s;
        scoreText.text = score.ToString();
    }
}
