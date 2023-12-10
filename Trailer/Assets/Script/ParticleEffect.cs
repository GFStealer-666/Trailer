using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffect : MonoBehaviour
{
    [SerializeField] ParticleSystem teleportEffect;
    public void OnOpenTeleport()
    {
        teleportEffect.Play();
    }
}
