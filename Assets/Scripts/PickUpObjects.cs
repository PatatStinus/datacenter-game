using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjects : MonoBehaviour
{
    [SerializeField] private Transform player; 
    private Renderer shader;
    private float distance;

    private void Start()
    {
        shader = GetComponent<Renderer>();
    }

    private void Update()
    {
        distance = Vector2.Distance(transform.position, player.position);
        shader.material.SetFloat("_Distance", distance);
    }
}
