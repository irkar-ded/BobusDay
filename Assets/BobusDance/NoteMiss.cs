using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NoteMiss : MonoBehaviour
{
    GameObject NoteScoll;
    public NoteAccuracy noteAccuracy;
    public int miss;
    public GameObject CanvasUp;
    public Text missText;

    void Start()
    {

    }
    
    void Update()
    {
        missText.text = "miss:" + miss;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Instantiate(CanvasUp, transform.position, transform.rotation);
        noteAccuracy.Score--;
        noteAccuracy.Accuracy--;
        miss++;
        NoteScoll = coll.gameObject;
        DestroyObject(NoteScoll);
    }
}
