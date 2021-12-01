using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slidertimer : MonoBehaviour
{
    public Slider timeSlider;
    public Text timeSliderText;
    public float gameTime;

    private bool stopTimer;

    void Start()
    {
        //start de timer bij opstarten game, moet nog omgezet naar button 
        stopTimer = false;
        timeSlider.maxValue = gameTime;
        timeSlider.value = gameTime;

    }

    // Update is called once per frame
    void Update()
    {
        float time = gameTime - Time.time;
        
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        string textTime = string.Format("{00}", seconds);
        
        // stopt bij 0
        if ( time <= 0)
        {
            stopTimer = true;
        }

        if ( stopTimer == false)
        {
            timeSliderText.text = textTime;
            timeSlider.value = time;

        }

    }
}