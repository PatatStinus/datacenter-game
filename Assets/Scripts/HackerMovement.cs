using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackerMovement : MonoBehaviour
{
    int currentPathPoint;
    [SerializeField] GameObject[] pathPoints;
    bool GoLeft;
    bool hasFile;

    // Start is called before the first frame update
    void Start()
    {
        GoLeft = (int)Mathf.Floor(Random.Range(0, 2)) == 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        hasFile |= currentPathPoint >= pathPoints.Length - 1;

        if (currentPathPoint < 0)
        {
            Destroy(gameObject);
            return;
        }

        if (transform.position == pathPoints[currentPathPoint].transform.position)
            if (hasFile)
            {
                currentPathPoint--;

                if (currentPathPoint == 4 || currentPathPoint == 5)
                    currentPathPoint = 2;
            }
            else
            {
                if (currentPathPoint == 2 && !GoLeft)
                    currentPathPoint += 1;

                currentPathPoint++;

                hasFile |= currentPathPoint == 3;
            }

        transform.position = Vector3.MoveTowards(transform.position, pathPoints[currentPathPoint].transform.position, 0.02f);
    }
}
