using System;
using UnityEngine;

public class GetCurrentSideCube : MonoBehaviour
{
    private Cube cube;

    private void Start()
    {
        cube = GetComponentInParent<Cube>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<SideCube>())
            cube.currentSideAbove = other.gameObject.GetComponent<SideCube>();
    }
}
