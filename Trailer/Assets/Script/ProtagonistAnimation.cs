using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class ProtagonistAnimation : MonoBehaviour
{
    [SerializeField] Animator mainAnimator;

    private void Awake() 
    {
        SetToWalk();
    }
    

    public void SetToIdle()
    {
        mainAnimator.SetTrigger("Idle");
    }

    public void SetToWalk()
    {
        mainAnimator.SetTrigger("Walk");
    }

    public void SetToWave()
    {
        mainAnimator.SetTrigger("Wave");
    }
    public void SetToTalk()
    {
        mainAnimator.SetTrigger("Talk");
    }

    public void SetToAccept()
    {
        mainAnimator.SetTrigger("Accept");
    }

    private void OnTriggerEnter(Collider other) 
    {
        switch(other.gameObject.name)
        {
            case "BridgeIdle" :
            SetToIdle();
            break;
        }
    }
}
