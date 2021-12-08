using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slidertimer : MonoBehaviour
{
    public Slider timeSlider;
    public Text timeSliderTextNumber;
    public float gameTime;
    public Button timerButton;
    float time = 0; 
    private bool stopTimer = true;

    void Start()
    {
     // sets up "download" button 
        Button btn = timerButton.GetComponent<Button>();
        btn.onClick.AddListener(TimerStart);
    }

    // when button pressed, this happens
    public void TimerStart()
    {

        if (stopTimer == true)
        {
            stopTimer = false;
            timeSlider.maxValue = gameTime;
            timeSlider.value = gameTime;
        }
    }

    void Update()
    {
     
        // stopt timer bij 10 seconden (100%)
        if ( time >= 10)
        {
            stopTimer = true;
            timeSliderTextNumber.text = "Download successful!";
        }

        // als timer loopt:
        if ( stopTimer == false)
        {
            time += Time.deltaTime;
            timeSliderTextNumber.text = "Downloading: " + (time * 10).ToString("0.00") + "%";
            timeSlider.value = time;

        }

    }
}