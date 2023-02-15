using UnityEngine;

public class triggerAudio : MonoBehaviour
{
    //public AudioClip myAudioClip;
    private AudioSource myAudioSource;

    //variable to prevent audio from triggering more than once
    bool canPlay;

    // Start is called before the first frame update
    void Start()
    {
        //get audio source from object
        myAudioSource = GetComponent<AudioSource>();

        canPlay = true;
        // assign the clip we want to the audio source
        //myAudioSource.clip = myAudioClip;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(canPlay)
        {
            myAudioSource.Play();
            canPlay = false;

        }
        
    }
}
