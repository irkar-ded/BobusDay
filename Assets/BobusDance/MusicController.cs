using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    
    void Update()
    {
        if(PlayerPrefs.GetString("music") == "No")
        {
            gameObject.SetActive(false);
        }
    }
}
