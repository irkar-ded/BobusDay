using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
public class IsEndDL : MonoBehaviour
{
    public GameObject dialogueZone;
    public UnityEvent End;
    int i = 0;
    void Update() {
        if(dialogueZone.activeSelf  == false)
        {
            FMODUnity.RuntimeManager.StudioSystem.setParameterByName("State_music1", 1f);
            if(i == 0){
                FMODUnity.RuntimeManager.StudioSystem.setParameterByName("State_music1", 2f);
                End.Invoke();
                i = 1;
            }
        }
    }
}

