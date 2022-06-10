using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    public GameObject[] objects;
    void Update()
    {
        for (var i = 0; i < objects.Length; i++)
        {
            Physics2D.IgnoreCollision(objects[i].GetComponent<Collider2D>(), GetComponent<Collider2D>());
            //FMODUnity.RuntimeManager.StudioSystem.setParameterByName("State_music1", 2f);
        }
    }
}
