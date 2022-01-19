using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickMovement : MonoBehaviour
{
    public GameObject joystick;
    public GameObject joystickBG;
    public Vector2 joystickVec;
    public float minX, maxX, minY, maxY;
    private Vector2 joystickTouchPos;
    private Vector2 joystickOriginalPos;
    private float joystickRadius;

    private void Start()
    {
        joystickOriginalPos = joystickBG.transform.position;
        joystickRadius = joystickBG.GetComponent<RectTransform>().sizeDelta.y / 2.5f;
    }

    public void PointerDown()
    {
        joystick.transform.position = Input.mousePosition;
        joystick.transform.localPosition = new Vector2(Mathf.Clamp(joystick.transform.localPosition.x, minX, maxX), Mathf.Clamp(joystick.transform.localPosition.y, minY, maxY));
        joystickBG.transform.position = joystick.transform.position;
        joystickTouchPos = joystick.transform.position;
    }

    public void Drag(BaseEventData baseEventData)
    {
        PointerEventData pointerEventData = baseEventData as PointerEventData;
        Vector2 dragPos = pointerEventData.position;
        joystickVec = (dragPos - joystickTouchPos).normalized;

        float joystickDist = Vector2.Distance(dragPos, joystickTouchPos);

        if(joystickDist < joystickRadius)
            joystick.transform.position = joystickTouchPos + joystickVec * joystickDist;
        else
            joystick.transform.position = joystickTouchPos + joystickVec * joystickRadius;
    }

    public void PointerUp()
    {
        joystickVec = Vector2.zero;
        joystick.transform.position = joystickOriginalPos;
        joystickBG.transform.position = joystickOriginalPos;
    }
}
