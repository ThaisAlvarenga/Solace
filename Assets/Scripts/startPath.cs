using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class startPath : MonoBehaviour
{

    public CinemachineDollyCart cart;
    public float speedIncrement = 0.01f;
    private float currentSpeed = 0f;

    public void changeCartSpeed()
    {
        if (currentSpeed < 0.1f)
        {
            currentSpeed += speedIncrement * Time.deltaTime;
            cart.m_Speed = currentSpeed;
        }

        cart.m_Speed = 0.1f;
    }
}