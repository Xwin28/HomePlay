using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildAction : MonoBehaviour
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
    public void PlaywithChild()
    {
        PlaySFX();
        if(Infor.instance_Infor.m_ChildCurrentStrees < Infor.instance_Infor.m_ChildMaxStrees)
        {
            Infor.instance_Infor.m_ChildCurrentStrees -= 2;
        }
        else
        {
            Infor.instance_Infor.m_ChildCurrentStrees = 0;
        }

        if (Infor.instance_Infor.m_PlayerCurrentStrees < Infor.instance_Infor.m_PlayerMaxStrees)
        {
            Infor.instance_Infor.m_PlayerCurrentStrees -= 1;
        }
        else
        {
            Infor.instance_Infor.m_PlayerCurrentStrees = 0;
        }
    }
}
