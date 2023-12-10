using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera firstPersonCam;
    [SerializeField] private float shakeTimerTotal, shakeTimer , Timer = 1;
    [SerializeField] private float  startingIntensity , intensity = 5f;

    public void ShakeCamera()
    {
        shakeTimer = Timer;
        CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin = 
        firstPersonCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

        cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = intensity;
        startingIntensity = intensity;
        shakeTimerTotal = Timer;
    }

    public void SetLightTimer()
    {
        Timer = 13f;
    }

    public void ShakeCameraLight()
    {
        shakeTimer = Timer;
        CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin = 
        firstPersonCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

        cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = 0.2f;
        cinemachineBasicMultiChannelPerlin.m_FrequencyGain = 3f;
        startingIntensity = intensity;
        shakeTimerTotal = Timer;
    }

    void Update()
    {
        if(shakeTimer > 0)
        {
            shakeTimer -= Time.deltaTime;
            if(shakeTimer <= 0f)
            {
                CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin = 
                firstPersonCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

                cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = 0;

                Mathf.Lerp(startingIntensity , 0f , 1-(shakeTimer /shakeTimerTotal));
            }
        }
    }
}
