using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScroll : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = new Vector3(0f, speed, 0f);
        transform.position += temp;
    }
}
