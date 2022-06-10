using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Boss : MonoBehaviour
{
    float Timer;
    public float TimeEvent;
    public UnityEvent[] Event;
    // Start is called before the first frame update
    void Start()
    {
        Event[0].Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if(Timer >= TimeEvent)
        {
            Event[Random.Range(0,Event.Length)].Invoke();
            Timer = 0;
        }
    }
}
