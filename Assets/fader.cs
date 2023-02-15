using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fader : MonoBehaviour
{
    public GameObject objectToFade; // The game object to fade in
    public float fadeInDuration = 2.0f; // The duration of the fade-in effect
    public AnimationCurve fadeCurve; // The curve used to interpolate the fade-in effect
    private float currentFadeTime; // The current time of the fade-in effect

    private bool isFading; // Whether the object is currently fading in

    private void OnTriggerEnter(Collider other)
    {
            // Start fading in the object
            isFading = true;
            currentFadeTime = 0.0f;

    }

    private void Update()
    {
        if (isFading)
        {
            // Increase the current fade time by the elapsed time since the last frame
            currentFadeTime += Time.deltaTime;

            // Calculate the fade amount using the fade curve
            float fadeAmount = fadeCurve.Evaluate(currentFadeTime / fadeInDuration);

            // Set the object's alpha value to the fade amount
            Color objectColor = objectToFade.GetComponent<Renderer>().material.color;
            objectColor.a = fadeAmount;
            objectToFade.GetComponent<Renderer>().material.color = objectColor;

            // Stop fading when the fade duration is reached
            if (currentFadeTime >= fadeInDuration)
            {
                isFading = false;
            }
        }
    }
}
