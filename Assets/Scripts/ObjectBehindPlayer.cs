using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehindPlayer : MonoBehaviour
{
    private void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y);
    }
}
