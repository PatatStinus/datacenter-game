using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMovement : MonoBehaviour
{
    [SerializeField] private GameObject stick;
    [SerializeField] private Transform bigCube;

    private void Update()
    {
        stick.transform.position = Input.mousePosition;
        //Stop stick from getting out of big cube bounds
    }
}
