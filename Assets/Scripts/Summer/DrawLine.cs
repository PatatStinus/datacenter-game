using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    public Vector3 startPos;
    LineRenderer line;

    void Start()
    {
        startPos = transform.position;
        line = GetComponent<LineRenderer>();
    }

    void Update()
    {
        line.material = GetComponent<Renderer>().material;
        Vector3[] positions = { startPos, transform.position };

        line.SetPositions(positions);
    }
}
