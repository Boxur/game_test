using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFollow : MonoBehaviour
{

    [SerializeField] Transform pos;
    [SerializeField] Transform target;
    private Vector3 delta;
    private float distance;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta = target.position - pos.position;
        delta /= 2;
        delta.z = 0;
        delta.Normalize();
        distance = delta.magnitude;
        delta = delta * distance * distance;
        pos.position += delta;
    }
}
