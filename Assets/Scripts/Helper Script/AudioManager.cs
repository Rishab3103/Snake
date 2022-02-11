using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioClip pickup_Sound, dead_Sound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void MakeInstance()
    {
        if(instance== null)
        {
            instance = this;
        }
    }

    public void Play_PickUpSound()
    {
        AudioSource.PlayClipAtPoint(pickup_Sound, transform.position);
    }

    public void Play_DeadSound()
    {
        AudioSource.PlayClipAtPoint(dead_Sound, transform.position);
    }
}
