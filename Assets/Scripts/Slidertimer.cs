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


    private bool stopTimer;

    void Start()
    {

        Button btn = timerButton.GetComponent<Button>();
        btn.onClick.AddListener(TimerStart);
        stopTimer = true;
    }


    public void TimerStart()
    {

        if (stopTimer == true)
        {
            stopTimer = false;
            timeSlider.maxValue = gameTime;
            timeSlider.value = gameTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
    //time elapsed since scene load. How make time elapsed since button press?
        float time = gameTime - Time.time;
        
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        string textTime = string.Format("{00}", seconds);
        
        // stopt bij 0
        if ( time <= 0)
        {
            stopTimer = true;
            timeSliderTextNumber.text = "Download successful!";

        }

        if ( stopTimer == false)
        {
            timeSliderTextNumber.text = "Time remaining: " + textTime;
            timeSlider.value = time;

        }

    }
}