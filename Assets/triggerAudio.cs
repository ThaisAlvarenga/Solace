using UnityEngine;

public class triggerAudio : MonoBehaviour
{
    //public AudioClip myAudioClip;
    private AudioSource myAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        //get audio source from object
        myAudioSource = GetComponent<AudioSource>();
        // assign the clip we want to the audio source
        //myAudioSource.clip = myAudioClip;
    }

    private void OnTriggerEnter(Collider other)
    {
        myAudioSource.Play();
    }
}
