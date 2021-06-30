using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitX : MonoBehaviour
{
    [SerializeField] GameObject RotationPoint;
    [SerializeField] float value;
    [SerializeField] float speed; 
    void Update()
    {
        Debug.DrawLine(transform.position, RotationPoint.transform.position, Color.green);
        transform.RotateAround(RotationPoint.transform.position, RotationPoint.transform.right, value * speed);
    }
}
