using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFollow : MonoBehaviour
{
    public float strength;
    [SerializeField] Transform target;
    public Vector3 delta;

    void LateUpdate()
    {
        Vector3 desiredPos = target.position + delta;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, strength);
        transform.position += (smoothPos - transform.position)*Time.deltaTime*strength;
    }
}
