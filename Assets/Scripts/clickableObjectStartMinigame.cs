using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickableObjectStartMinigame : clickableObjectParent
{
    [SerializeField] GameManager GM;

    enum minigames
    {
        minigame_dataLeak,
        minigame_placeHolder
    };

    [SerializeField] minigames minigame;

    public override void ObjectClicked()
    {
        switch (minigame)
        {
            case minigames.minigame_dataLeak:
                {
                    //Instantiate()
                }
                break;

            case minigames.minigame_placeHolder:
                {
                    Debug.Log("test 2");
                }
                break;
        }
    }
}
