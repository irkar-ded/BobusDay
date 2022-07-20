using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCamera : AudioSyncer
{

	public  void Update()
	{
		base.OnUpdate();


		if (m_isBeat == true)
        {
			TimerPlus = beatScale;
			TimerMinus += Time.deltaTime * SpeadRestScale;
			if (TimerMinus >= beatScale)
			{
				TimerMinus = beatScale;
			}
			Camera.main.orthographicSize = TimerMinus;

			Invoke("StopBeat", beatScale);
		}
		if (m_isBeat == false)
		{
			TimerMinus = restScale;
			TimerPlus -= Time.deltaTime * SpeadBeatScale;
			if (TimerPlus <= restScale)
			{
				TimerPlus = restScale;
			}
			Camera.main.orthographicSize = TimerPlus;
		}
	}

	public override void OnBeat()
	{
		base.OnBeat();
       
	}

	void StopBeat()
    {
		m_isBeat = false;

	}
	float TimerPlus = 6;
	float TimerMinus = 5;
	public float beatScale;
	public float restScale;
	public float SpeadBeatScale;
	public float SpeadRestScale;

}
