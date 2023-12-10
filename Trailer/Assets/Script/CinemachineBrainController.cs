using Cinemachine;
using UnityEngine;

public class CinemachineBrainController : MonoBehaviour
{
    [SerializeField] private CinemachineBrain cinemachineBrain;

    [SerializeField] private CinemachineBlendDefinition cinemachineBlendDefinition;	

    public void OnEaseInOut()
    {
        cinemachineBlendDefinition.m_Style = CinemachineBlendDefinition.Style.EaseInOut;
        cinemachineBrain.m_DefaultBlend = cinemachineBlendDefinition;
    }

    public void OnCut()
    {
        cinemachineBlendDefinition.m_Style = CinemachineBlendDefinition.Style.Cut;
        cinemachineBrain.m_DefaultBlend = cinemachineBlendDefinition;
    }
}
