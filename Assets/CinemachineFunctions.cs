using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CinemachineFunctions : MonoBehaviour
{
    //https://www.youtube.com/watch?v=ACf1I27I6Tk
    public static CinemachineFunctions Instance { get; private set; }
    private CinemachineVirtualCamera cinVirtCam;
    private float shakeTimer;

    private void Awake()
    {
        Instance = this;
        cinVirtCam = GetComponent<CinemachineVirtualCamera>();
    }
    public void ShakeCamera(float intensity, float time)
    {
        CinemachineBasicMultiChannelPerlin cinPerlin = cinVirtCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        cinPerlin.m_AmplitudeGain = intensity;
        shakeTimer = time;
    }
    private void Update()
    {
        if (shakeTimer > 0)
        {
            shakeTimer -= Time.deltaTime;
            if (shakeTimer <= 0)
            {
                CinemachineBasicMultiChannelPerlin cinPerlin = cinVirtCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
                cinPerlin.m_AmplitudeGain = 0;
            }
        }
    }
}
