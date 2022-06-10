using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;
using FMOD.Studio;
using System;

public class Sounds_Character : MonoBehaviour
{
    public FMODUnity.EventReference Walk_Event;
    public FMODUnity.EventReference Run_Event;
    public FMODUnity.EventReference Jump_Event;
    public FMODUnity.EventReference JumpAir_Event;
    public FMODUnity.EventReference Land_Event;
    //weаpons
    FMOD.Studio.EventInstance GlideAir_Inst;
    FMOD.Studio.EventInstance JatPack_Inst;
    public FMODUnity.EventReference ShotGun_Event;
    //public FMODUnity.EventReference JatPackEnd_Event;
    //Enemy Sounds
    public FMODUnity.EventReference ShotGunNPC_Event;

    private void Start()
    {
        
    }

    private void walk_sound()
    {
        FMODUnity.RuntimeManager.PlayOneShot(Walk_Event, transform.position);
    }
    private void run_sound()
    {
        FMODUnity.RuntimeManager.PlayOneShot(Run_Event, transform.position);
    }
    public void jump_sound()
    {
        FMODUnity.RuntimeManager.PlayOneShot(Jump_Event, transform.position);
    }
    public void jumpAir_sound()
    {
        FMODUnity.RuntimeManager.PlayOneShot(JumpAir_Event, transform.position);
    }
    public void land_sound()
    {
        FMODUnity.RuntimeManager.PlayOneShot(Land_Event, transform.position);
    }
    //weapons
    public void glideAir_sound()
    {
        GlideAir_Inst = FMODUnity.RuntimeManager.CreateInstance("event:/Character/Weapon/GlideAir");
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(GlideAir_Inst, gameObject.GetComponent<Transform>(), gameObject.GetComponent<Rigidbody2D>());
        GlideAir_Inst.start();
        GlideAir_Inst.release();
    }
    public void jatPack_sound()
    {
        JatPack_Inst = FMODUnity.RuntimeManager.CreateInstance("event:/Character/Weapon/Jetpack");
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(JatPack_Inst, gameObject.GetComponent<Transform>(), gameObject.GetComponent<Rigidbody2D>());
        JatPack_Inst.start();
        JatPack_Inst.release();
    }
    public void shotGun_sound()
    {
        FMODUnity.RuntimeManager.PlayOneShot(ShotGun_Event, transform.position);
        /*Shote = FMODUnity.RuntimeManager.CreateInstance("event:/Character/Weapon/ShotGun");
        Shote.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(transform.position));
        Shote.start();
        Shote.release();*/
    } 
    //Enemy sounds
    public void shotGunNPC_sound()
    {
        FMODUnity.RuntimeManager.PlayOneShot(ShotGunNPC_Event, transform.position);
    }
    //стопы инстансов
    void glideAir_Stop()
    {
        GlideAir_Inst.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }
    void jatpack_Stop()
    {
        JatPack_Inst.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }
}
