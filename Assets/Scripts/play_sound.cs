using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class play_sound : MonoBehaviour
{
    AudioSource myAudioSource;

    void Start()
    {
        myAudioSource = GetComponentInChildren<AudioSource>();    
    }

    public void PLAY()
    {
        myAudioSource.Play();
    }

}
