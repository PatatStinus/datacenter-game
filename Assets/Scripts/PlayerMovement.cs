using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveSpeed = 0.1f;
    float horizontalMove = 0;
    float verticalMove = 0;
    public float zPos = 0;
    public float scaleMod = 1;
    GameObject character;

    // Start is called before the first frame update
    void Start()
    {
        character = gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalMove = Input.GetAxis("Horizontal") * moveSpeed;
        verticalMove = Input.GetAxis("Vertical") * moveSpeed;
        character.transform.Translate(new Vector3(horizontalMove, verticalMove, 0));
        float charY = Mathf.Clamp(character.transform.position.y, -10f, 0);
        float charX = Mathf.Clamp(character.transform.position.x, -6, 6);
        zPos = charY / -10f * -5;
        character.transform.position = new Vector3(charX, charY, zPos);
        scaleMod = (character.transform.position.y / -1.5f) / 4 + 0.25f;
        character.transform.localScale = new Vector3(scaleMod, scaleMod, 1);
    }
}
