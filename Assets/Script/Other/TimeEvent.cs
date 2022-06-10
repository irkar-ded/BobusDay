using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class TimeEvent : MonoBehaviour
{
    public bool IsStart;
    public UnityEvent timeEvent;
    bool startTime = false;
    float scoreTime = 0;
    private void Start() {
        if(IsStart == true)
        {
            timeEvent.Invoke();
        }
    }
    void Update()
    {
        if(startTime == true)
        {
            scoreTime -= Time.deltaTime;
            if(scoreTime <= 0)
            {
                timeEvent.Invoke();
                scoreTime = 0;
                startTime = false;
            }
        }
    }
    public void OnStarTimer(float Time)
    {
        scoreTime = Time;
        startTime = true;
    }
}
