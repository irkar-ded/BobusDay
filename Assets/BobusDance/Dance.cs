using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance : MonoBehaviour
{
    public Animator anim;
    public KeyCode Left;
    public KeyCode Right;
    public KeyCode Up;
    public KeyCode Down;
    void Start()
    {
        
    }

 
    void Update()
    {
        if (Input.GetKeyDown(Left))
        {
            anim.SetBool("DownNote", false);
            anim.SetBool("UpNote", false);
            anim.SetBool("RightNote", false);
            anim.SetBool("LeftNote", true);
        }

        if (Input.GetKeyDown(Right))
        {
            anim.SetBool("DownNote", false);
            anim.SetBool("UpNote", false);
            anim.SetBool("LeftNote", false);
            anim.SetBool("RightNote", true);
        }
        if (Input.GetKeyDown(Up))
        {
            anim.SetBool("DownNote", false);
            anim.SetBool("RightNote", false);
            anim.SetBool("LeftNote", false);
            anim.SetBool("UpNote", true);
        }
        if (Input.GetKeyDown(Down))
        {
            anim.SetBool("UpNote", false);
            anim.SetBool("RightNote", false);
            anim.SetBool("LeftNote", false);
            anim.SetBool("DownNote", true);
        }
        if (Input.GetKeyUp(Left))
        {
            anim.SetBool("DownNote", false);
            anim.SetBool("UpNote", false);
            anim.SetBool("RightNote", false);
            anim.SetBool("LeftNote", false);
        }

        if (Input.GetKeyUp(Right))
        {
            anim.SetBool("DownNote", false);
            anim.SetBool("UpNote", false);
            anim.SetBool("RightNote", false);
            anim.SetBool("LeftNote", false);
        }
        if (Input.GetKeyUp(Up))
        {
            anim.SetBool("DownNote", false);
            anim.SetBool("UpNote", false);
            anim.SetBool("RightNote", false);
            anim.SetBool("LeftNote", false);
        }
        if (Input.GetKeyUp(Down))
        {
            anim.SetBool("DownNote", false);
            anim.SetBool("UpNote", false);
            anim.SetBool("RightNote", false);
            anim.SetBool("LeftNote", false);
        }
    }
}
