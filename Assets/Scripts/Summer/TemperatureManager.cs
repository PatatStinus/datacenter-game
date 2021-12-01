using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TemperatureManager : MonoBehaviour
{
    [SerializeField] TMP_Text tempDisplay;

    [SerializeField] float timer;

    float insideTemp;

    public bool guaranteedFire;

    int desiredTemp = 25;

    private void Start()
    {
        insideTemp = Random.Range(20, 30);
        guaranteedFire = false;
    }

    private void Update()
    {
        tempDisplay.text = Mathf.FloorToInt(insideTemp).ToString();

        timer -= Time.deltaTime;

        if (insideTemp >= 45)
            insideTemp = 45;
        if (insideTemp <= 15)
            insideTemp = 15;
        if (insideTemp <= 45 && insideTemp >= 31)
            guaranteedFire = true;

        if (Random.Range(0, 10) == 10 && insideTemp > desiredTemp)
            guaranteedFire = true;

        if (timer <= 0)
        {
            insideTemp = Random.Range(20, 30);

            if (Random.Range(0, 10) == 10)
                insideTemp = Random.Range(31, 45);           
            
            timer = Random.Range(4, 8);
        }
    }

    public void IncreaseTemperature()
    {
        insideTemp += 1;

        if (insideTemp == desiredTemp)
            timer = 20;
    }

    public void DecreaseTemperature()
    {
        insideTemp -= 1;

        if (insideTemp == desiredTemp)
            timer = 20;
    }
}
