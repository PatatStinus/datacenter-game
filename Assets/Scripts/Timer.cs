using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timer;
    [SerializeField] TMP_Text timeText;

    private void Update()
    {
        if (timer >= 0)
        {
            float minutes = Mathf.FloorToInt(timer / 60);
            float seconds = Mathf.FloorToInt(timer % 60);

            timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

            timer -= Time.deltaTime;
        }
    }
}
