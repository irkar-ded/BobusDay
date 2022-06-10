using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPoint : MonoBehaviour
{
    public Transform Point;
    void Update()
    {
        transform.LookAt(Point);
    }
}
