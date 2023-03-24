using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeInTrigger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public float fadeInTime = 1f;

    private bool isFading = false;
    private Color originalColor;

    private void Start()
    {
        spriteRenderer.gameObject.SetActive(false);
        originalColor = spriteRenderer.color;
    }

    private void OnTriggerEnter(Collider other)
    {

        isFading = true;
        spriteRenderer.gameObject.SetActive(true);
        Debug.Log("trigger entered");
 
    }

    private void Update()
    {
        if (isFading)
        {
            float alpha = Mathf.Clamp01(Time.time / fadeInTime);
            spriteRenderer.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            if (alpha == 1f)
            {
                isFading = false;
            }
        }
    }
}
