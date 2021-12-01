using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TemperatureManager : MonoBehaviour
{
    [SerializeField] Button openVent;
    [SerializeField] Button closeVent;

    [SerializeField] TMP_Text tempDisplay;

    [SerializeField] float timer;

    [SerializeField] int insideTemp;
    [SerializeField] int outsideTemp;
    [SerializeField] int currentRoomTemp;
    int desiredTemp = 25;

    private void Start()
    {
        currentRoomTemp = Random.Range(25, 28);
        outsideTemp = Random.Range(2, 35);
        insideTemp = 60;
    }

    private void Update()
    {
        /*The inside temperature needs to take how far the vent is open into consideration
         the vent needs to calculate the outside temperature and how much air it lets in
         the amount of air it lets in needs to be calculated compared to how much air is in the room
         this amount needs to be mixed with the currentInsideTemp and calculated against the insideTemp (hardware output temperature)
         the currentRoomTemp needs to increment or decrement very fast towards the calculated temp

         every 10 seconds? there could be a 50% chance of a temperature changing
         temperatures have a small-ish chance of going super high which can result in fires
        
         once the room reaches optimal temperature, the next timer can increase by 30 seconds?
         */


        timer -= Time.deltaTime;

        if (timer <= 0)
        {

        }
    }

    private void CloseVent()
    {

    }

    private void OpenVent()
    {

    }
}
