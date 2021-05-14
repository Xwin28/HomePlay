using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HireEmp : MonoBehaviour
{
    public enum Skill_emp { Play, Feed, Clean, All}
    public float m_Price;
    public Skill_emp m_skill;

    public AudioSource Sourcesfx;
    public AudioClip fxSucces, fxFail;
    private void Start()
    {
        if (GetComponent<AudioSource>())
            Sourcesfx = GetComponent<AudioSource>();
    }
    public void PlaySFX(AudioClip sfx)
    {
        if (Sourcesfx != null)
        {
            Sourcesfx.pitch = UnityEngine.Random.Range(0.1f, 0.2f);
            Sourcesfx.PlayOneShot(sfx);
        }

    }



    public void Hire()
    {
        if (Infor.instance_Infor.m_Coin >= m_Price)
        {
            PlaySFX(fxSucces);
            Infor.instance_Infor.m_Coin -= m_Price;

            if(m_skill ==Skill_emp.Play)
            {
                Infor.instance_Infor.m_hire = Infor.Skill_emp.Play;
            }
            else if( m_skill == Skill_emp.Feed)
            {
                Infor.instance_Infor.m_hire = Infor.Skill_emp.Feed;
            }
            else if (m_skill == Skill_emp.Clean)
            {
                Infor.instance_Infor.m_hire = Infor.Skill_emp.Clean;
            }
            else if (m_skill == Skill_emp.All)
            {
                Infor.instance_Infor.m_hire = Infor.Skill_emp.All ;
            }
        }
        else
        {
            PlaySFX(fxFail);
        }
    }
}
