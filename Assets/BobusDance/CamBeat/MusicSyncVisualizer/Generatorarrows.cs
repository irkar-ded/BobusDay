using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generatorarrows : AudioSyncer
{
	public Transform[] SpawnsPos;
	public GameObject[] Arrows;
	public void Update()
	{
		base.OnUpdate();


	}

	public override void OnBeat()
	{
		base.OnBeat();
		int RandomNamber;
		RandomNamber = Random.Range(0, Arrows.Length);
		Instantiate(Arrows[RandomNamber], SpawnsPos[RandomNamber].position, SpawnsPos[RandomNamber].rotation);
	}

	void StopBeat()
	{
		

	}
	public float beatScale;
	public float restScale;
	public float SpeadBeatScale;
	public float SpeadRestScale;
}
