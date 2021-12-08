using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameParent : MonoBehaviour
{
    [SerializeField] GameManager GM;

    // Start is called before the first frame update
    void Start()
    {
        GM.minigameActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDisabled()
    {
        GM.minigameActive = false;
    }
}
