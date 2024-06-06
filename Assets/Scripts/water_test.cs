using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_test : MonoBehaviour
{
    Animator myAnim;
    AudioSource myAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        myAnim.SetBool("Water", true);
        myAudioSource.Play();
        Invoke("delayedSwitch", 2.0f);
    }
    public void delayedSwitch()
    {
        myAnim.SetBool("Water", false);
    }
}
