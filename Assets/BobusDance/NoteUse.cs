using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteUse : MonoBehaviour
{
    GameObject NoteScoll;
    public NoteAccuracy noteAccuracy;
    bool EnterTrigger;
    public KeyCode NoteKey;
    public GameObject CanvasUp;
    public GameObject Splah;
    public Sprite NoteUp;
    public Sprite NoteDown;
    SpriteRenderer ArowSprite;

    void Start()
    {
        ArowSprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if(EnterTrigger == true)
        {
            if (Input.GetKey(NoteKey))
            {
                Instantiate(CanvasUp, transform.position, transform.rotation);
                Instantiate(Splah, transform.position, transform.rotation);
                noteAccuracy.Accuracy += 0.1f;
                noteAccuracy.Score++;
                DestroyObject(NoteScoll);
            }
        }
        if (Input.GetKeyDown(NoteKey))
        {
            ArowSprite.sprite = NoteDown;
        }
        if (Input.GetKeyUp(NoteKey))
        {
            ArowSprite.sprite = NoteUp;
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
