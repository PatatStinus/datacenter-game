using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timer;
    public int score;
    [SerializeField] TMP_Text timeText;
    [SerializeField] TMP_Text scoreText;

    private void Start()
    {
        score = 0;       
    }

    private void Update()
    {
        CountDown();
        scoreText.text = score.ToString();
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
    }

    public void AddScore(int s)
    {
        score += s;
    }
}
