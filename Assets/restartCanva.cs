using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class restartCanva : MonoBehaviour
{
    public titleParticles canvaManager;
    public CinemachineDollyCart cart;
    public float speedDecrement = 0.01f;
    private float currentSpeed = 0;

    private void Start()
    {
        currentSpeed = cart.m_Speed;
}
    private void OnTriggerEnter(Collider other)
    {
        if (currentSpeed > 0f)
        {
            currentSpeed -= speedDecrement * Time.deltaTime;
            cart.m_Speed = currentSpeed;
        }

        cart.m_Speed = 0f;

        canvaManager.reloadCanvas();
    }
}
