using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CableManager : MonoBehaviour
{
    Transform hitCable;

    //RaycastHit2D hit;

    bool isHoldingCable;

    [SerializeField] LayerMask cableLayer;

    [SerializeField] List<Transform> cables;
    [SerializeField] List<Transform> cableConnectors;

    public List<Transform> randomCables;

    Collider2D target;

    private void Start()
    {
        isHoldingCable = false;
        hitCable = null;

        for (int i = 0; i < 4; i++)
        {
            int random = Random.Range(0, cables.Count - 1);
            randomCables.Add(cables[random]);
            cables.Remove(cables[random]);
        }
    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit, 1000, cableLayer) && randomCables.Contains(hit.transform))
        {
            if (Input.GetMouseButtonDown(0))
            {
                hitCable = hit.transform;
                Debug.Log(hitCable);
            }
            else if (Input.GetMouseButtonUp(0))
                hitCable = null;

            if (hitCable == null)
                return;

            hitCable.position = new Vector3(hit.point.x, hit.point.y, hitCable.position.z);
        }

        for (int j = 0; j < randomCables.Count; j++)
        {
            for (int i = 0; i < cableConnectors.Count; i++)
            {
                if (randomCables[j] == hitCable && j == i)
                {
                    if (Vector3.Distance(cableConnectors[i].position, hitCable.position) < 2f)
                    {
                        //hitCable.position = cableConnectors[i].position;
                        randomCables.Remove(randomCables[i]);
                        cableConnectors.Remove(cableConnectors[i]);
                        hitCable = null;
                    }
                }
            }
        }
    }
}
