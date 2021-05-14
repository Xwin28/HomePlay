using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource Sourcesfx;
    public AudioClip fx;

    private void Start()
    {
        if (GetComponent<AudioSource>())
            Sourcesfx = GetComponent<AudioSource>();
    }
    public void PlaySFX()
    {
        if (Sourcesfx != null)
        {
           
            Sourcesfx.PlayOneShot(fx);
        }

    }
}
