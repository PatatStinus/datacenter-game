using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CableManager : MonoBehaviour
{
    Transform hitCable;

    RaycastHit2D hit;

    [SerializeField] LayerMask cableLayer;

    private void Start()
    {
        hitCable = null;
    }

    private void Update()
    {
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //hit = Physics2D.Raycast(Input.mousePosition, ray.direction, cableLayer);

        //if (hit)
        //{
        //    hitCable = hit.transform;

        //    Debug.Log(hit.transform.name);
        //    if (Input.GetMouseButton(0))
        //    {
        //        hitCable.position = new Vector3(hit.point.x, hit.point.y, hitCable.position.z);
        //    }
        //    else if (Input.GetMouseButtonUp(0))
        //        hitCable = null;
        //}


        //if (mousePos != null)
        //{
        //    hitCable = hit.transform;

        //    Debug.Log(hit.transform.name);
        //    if (Input.GetMouseButton(0))
        //    {
        //        hitCable.position = new Vector3(hit.point.x, hit.point.y, hitCable.position.z);
        //    }
        //    else if (Input.GetMouseButtonUp(0))
        //        hitCable = null;
        //}
    }
}
