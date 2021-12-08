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
        if (timer >= 0)
        {
            timer -= Time.deltaTime;

            float minutes = Mathf.FloorToInt(timer / 60);
            float seconds = Mathf.FloorToInt(timer % 60);

            timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
            gameOver = true;
    }

    public void AddScore(int s)
    {
        score += s;
        scoreText.text = score.ToString();
    }
}
