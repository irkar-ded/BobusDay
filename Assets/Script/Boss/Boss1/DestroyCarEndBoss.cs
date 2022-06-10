using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCarEndBoss : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Car")
        {
            Destroy(col.transform.gameObject);
        }
    }
}
