using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    private float cloudSpeed = 1.0f;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation" , Time.time * cloudSpeed );
    }
}
