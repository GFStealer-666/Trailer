using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NPCAnimation : MonoBehaviour
{

    private void OnEnable() 
    {
        CameraTriggerAnimation.OnNpcWave += SetToWave;
        CameraTriggerAnimation.OnNpcIdle += SetToIdle;
    }

    private void OnDisable() 
    {
         CameraTriggerAnimation.OnNpcWave -= SetToWave;
         CameraTriggerAnimation.OnNpcIdle -= SetToIdle;
    }
    [SerializeField] Animator npcAnimator;
    public void SetToIdle()
    {
        npcAnimator.SetTrigger("Idle");
    }

    public void SetToWalk()
    {
        npcAnimator.SetTrigger("Walk");
    }

    public void SetToWave()
    {
        npcAnimator.SetTrigger("Wave");
    }

    public void SetToSad()
    {
        npcAnimator.SetTrigger("Sad");
    }
    public void SetToHappy()
    {
        npcAnimator.SetTrigger("Happy");
    }

    public void SetToCry()
    {
        npcAnimator.SetTrigger("Cry");
    }
    public void SetToPoint()
    {
        npcAnimator.SetTrigger("Point");
    }

    private void OnTriggerEnter(Collider other) 
    {
        switch(other.gameObject.name)
        {
            case "CameraWave" :
            SetToWave();
            break;
        }
    }
}
