using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitY : MonoBehaviour
{
    [SerializeField] GameObject RotationPoint;
    [SerializeField] float value;

    void Update()
    {
        Debug.DrawLine(transform.position, RotationPoint.transform.position, Color.green);
        transform.RotateAround(RotationPoint.transform.position, RotationPoint.transform.up, value);
    }

    // Update is called once per frame

    
}
