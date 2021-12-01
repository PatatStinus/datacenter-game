using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMovement : MonoBehaviour
{
    [SerializeField] private GameObject stick;
    [SerializeField] private Transform bigCube;
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    Vector3 startPosition;

    private void Start()
    {

        //startpos klopt niet, moet afgesteld op boundary ipv world? 
        //script kan wss helemaal wel weg ivm built-in movement control systems
        startPosition = new Vector3(919,-387,0);
        screenBounds = new Vector2(bigCube.localScale.x, bigCube.localScale.y);
        objectWidth = stick.transform.localScale.x;
        objectHeight = stick.transform.localScale.y;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 viewPos = Input.mousePosition;
            if (viewPos.x < 719)
            { viewPos.x = 719; }
         //  viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
         //  viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + objectHeight, screenBounds.y - objectHeight);
            stick.transform.localPosition = viewPos;
            //stick.transform.position = Input.mousePosition;
        }
        else
            stick.transform.localPosition = startPosition;



        //Stop stick from getting out of big cube bounds
    }
}
