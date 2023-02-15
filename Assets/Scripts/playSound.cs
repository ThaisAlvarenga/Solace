using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class playSound : MonoBehaviour
{
    public AudioClip sound;
    public float volume;
    AudioSource myaudio;

    // Start is called before the first frame update
    void Start()
    {
        myaudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        myaudio.PlayOneShot(sound, volume);
        Debug.Log("Sound here");
    }
}
