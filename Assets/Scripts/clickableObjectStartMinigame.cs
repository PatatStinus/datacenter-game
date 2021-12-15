using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickableObjectStartMinigame : clickableObjectParent
{
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
                    Debug.Log("test");
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
