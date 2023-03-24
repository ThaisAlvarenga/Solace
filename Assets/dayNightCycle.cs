using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayNightCycle : MonoBehaviour
{
    public Light directionalLight;
    public float rotationSpeed = 1f;
    public float cycleDuration = 120f; // 2 minutes

    private float timeOfDay = 0f;

    private bool doCycle = false;

    private Quaternion startRotation;

    private void Start()
    {
        startRotation = directionalLight.transform.rotation;
    }

    private void Update()
    {
        if(doCycle)
        {
            // Rotate light from original position
            if (timeOfDay < cycleDuration / 2f)
            {
                Quaternion targetRotation = Quaternion.Euler(45f, 0f, 0f);
                directionalLight.transform.rotation = Quaternion.Slerp(startRotation, targetRotation, timeOfDay / (cycleDuration / 2f));
            }

            //// Day-night cycle
            //float sunIntensity = 1f - Mathf.Abs(timeOfDay - cycleDuration / 2f) / (cycleDuration / 2f);
            //directionalLight.intensity = sunIntensity;

            float rotationAmount = rotationSpeed * Time.deltaTime;
            timeOfDay += rotationAmount;
            if (timeOfDay > cycleDuration)
            {
                timeOfDay -= cycleDuration;
            }
        }
    }

    public void startDayNightCycle()
    {
        doCycle = true;
    }
}
