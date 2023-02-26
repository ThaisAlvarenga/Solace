using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cameraShake : MonoBehaviour
{
    // Start is called before the first frame update

    public float shakeDuration = 0.5f;
    public float shakeStrength = 0.1f;

    public CinemachineVirtualCamera mycamera;

    private Transform cameraTransform;

    Vector3 initialPosition;

    bool isShaking = false;
    void Start()
    {
        cameraTransform = mycamera.transform;
        initialPosition = cameraTransform.localPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        Invoke("StartShake", 1f);
    }

    void StartShake()
    {
        if (!isShaking)
        {
            StartCoroutine(shake());
        }
    }

    IEnumerator shake()
    {
        isShaking = true;
        float timeElapsed = 0f;

        while(timeElapsed < shakeDuration)
        {
            Vector3 randomPos = initialPosition + Random.insideUnitSphere * shakeStrength;

            cameraTransform.localPosition = randomPos;

            timeElapsed += Time.deltaTime;

            Debug.Log("Shaking");

            yield return null;
        }

        cameraTransform.localPosition = initialPosition;
        isShaking = false;
    }
}
