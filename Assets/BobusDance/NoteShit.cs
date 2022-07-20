using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteShit : MonoBehaviour
{
    GameObject NoteScoll;
    bool EnterTrigger;
    public KeyCode NoteKey;
    public GameObject CanvasUp;
    public NoteAccuracy noteAccuracy;

    void Start()
    {
      
    }
    void Update()
    {
        if (EnterTrigger == true)
        {
            if (Input.GetKey(NoteKey))
            {
                Instantiate(CanvasUp, transform.position, transform.rotation);
                noteAccuracy.Accuracy -= 0.1f;
                DestroyObject(NoteScoll);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        NoteScoll = coll.gameObject;
        EnterTrigger = true;
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        NoteScoll = coll.gameObject;
        EnterTrigger = false;
    }
}
