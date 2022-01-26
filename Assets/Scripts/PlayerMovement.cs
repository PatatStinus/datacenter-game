using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public JoystickMovement joystickMovement;
    public float playerSpeed;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (joystickMovement.joystickVec.y != 0)
            rb.velocity = new Vector2(joystickMovement.joystickVec.x * playerSpeed, joystickMovement.joystickVec.y * playerSpeed);
        else
            rb.velocity = Vector2.zero;
    }

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y);
    }
}
