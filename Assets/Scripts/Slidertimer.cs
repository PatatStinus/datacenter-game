using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slidertimer : MonoBehaviour
{
    private float timeRemaining;
    private float timerMax;
    public Slidertimer slider;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = CalculateSliderValue();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            timeRemaining = timerMax;
        }

        if (timeRemaining <= 0)
        {
            timeRemaining = 0;
        }

        else if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
    }
    float CalculateSliderValue()
    {
        return (timeRemaining / timerMax);
    }
}
