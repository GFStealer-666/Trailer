using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraTriggerAnimation : MonoBehaviour
{
    public static event Action OnNpcIdle , OnNpcWave , OnNpcPoint;
    public static event Action OnMPIdle , OnMpWalk , OnMpWave;
    
    private void OnTriggerEnter(Collider other) 
    {
        switch(other.gameObject.name)
        {
            case "CameraWave" :
            Debug.Log("Jda");
            OnNpcWave?.Invoke();
            break;
        }
    }
}
