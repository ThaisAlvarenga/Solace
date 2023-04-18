using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleParticles : MonoBehaviour
{
    public TextPhotoParticles particleTextPhoto;

    public GameObject particleText;
    public float transitionTime = 1.0f;

    public string text1;

    public bool displayTitle = true;
    public Color textColor;

   

    Texture2D currentImage = null;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(displayTitle)
        {
            particleTextPhoto.MakeTextParticle(text1);
            currentImage = null;

            particleTextPhoto.fillColorType = TextPhotoParticles.enumTextureColorType.CustomColor;
            particleTextPhoto.customColor = textColor;


            displayTitle = false;
        }

        

    }

    public void reloadCanvas()
    {
        StartCoroutine(restartCanvas());
    }

    public void removeCanva()
    {
        StartCoroutine(disperseTitle());
        
        Debug.Log("canvas is removed");
    }

    IEnumerator disperseTitle()
    {
        particleTextPhoto.particleMode = TextPhotoParticles.enumParticlesMode.ParticleDisperse;

        yield return new WaitForSeconds(10f);

        particleText.SetActive(false);
    }

    IEnumerator restartCanvas()
    {
        particleTextPhoto.particleMode = TextPhotoParticles.enumParticlesMode.ParticleConverge;

        yield return new WaitForSeconds(10f);

        particleText.SetActive(true);
    }
    /*
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 5, 130, 35), "Switch Text 1"))
        {
            particleTextPhoto.MakeTextParticle(text1);
            currentImage = null;
        }


        if (GUI.Button(new Rect(10, 350, 130, 35), "Mouse Zoom"))
        {
            particleTextPhoto.mouseInteractive = TextPhotoParticles.enumMouseInteractive.MouseZoom;
        }

        if (GUI.Button(new Rect(10, 390, 130, 35), "Mouse Bounce"))
        {
            particleTextPhoto.mouseInteractive = TextPhotoParticles.enumMouseInteractive.MouseBounce;
        }


        if (GUI.Button(new Rect(10, 450, 130, 35), "Particle Converge"))
        {
            particleTextPhoto.particleMode = TextPhotoParticles.enumParticlesMode.ParticleConverge;
        }

        if (GUI.Button(new Rect(10, 490, 130, 35), "Particle Disperse"))
        {
            particleTextPhoto.particleMode = TextPhotoParticles.enumParticlesMode.ParticleDisperse;
        }




        if (GUI.Button(new Rect(Screen.width - 150, 5, 130, 35), "White Color"))
        {
            particleTextPhoto.fillColorType = TextPhotoParticles.enumTextureColorType.WhiteColor;
        }

        if (GUI.Button(new Rect(Screen.width - 150, 40, 130, 35), "Red Color"))
        {
            particleTextPhoto.fillColorType = TextPhotoParticles.enumTextureColorType.CustomColor;
            particleTextPhoto.customColor = new Color32(216, 158, 92, 255);
        }


    }*/
}
