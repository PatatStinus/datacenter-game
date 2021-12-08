using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CableManager : MonoBehaviour
{
    RaycastHit hit;

    Transform hitCable;

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (hitCable == null && Physics.Raycast(ray.origin, ray.direction, out hit))
        {
            Debug.Log(hit.transform.name);
            hitCable = hit.transform;
        }
        if (hitCable == null)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            hitCable.position = new Vector3(hit.point.x, hit.point.y, hitCable.position.z);
        }
        else
        {
            hitCable = null;
        }
    }
}
