using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickableObjectTest : clickableObjectParent
{
    public override void ObjectClicked()
    {
        Debug.Log("Test Object Clicked!");
    }
}
