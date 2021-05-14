using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyFood : MonoBehaviour
{
    public int m_Price;
    public int m_Hungry;
    public int m_Stress;
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
            
            Sourcesfx.PlayOneShot(sfx);
        }

    }
    public void Buy_Food()
    {
        if(Infor.instance_Infor.m_Coin >= m_Price)
        {
            PlaySFX(fxSucces);
            Infor.instance_Infor.m_Coin -= m_Price;
            float Temp_Hungry = Infor.instance_Infor.m_PlayerCurrentHungry + m_Hungry;
            float Temp_Stress = Infor.instance_Infor.m_PlayerCurrentStrees - m_Stress;
            if (Temp_Hungry > Infor.instance_Infor.m_PlayerMaxHungry)
            {
                Infor.instance_Infor.m_PlayerCurrentHungry = Infor.instance_Infor.m_PlayerMaxHungry;
            }
            else
            {
                Infor.instance_Infor.m_PlayerCurrentHungry = Temp_Hungry;
            }

            if (Temp_Stress < 0)
            {
                Infor.instance_Infor.m_PlayerCurrentStrees = 0;
            }
            else
            {
                Infor.instance_Infor.m_PlayerCurrentStrees = Temp_Stress;
            }
        }
        else
        {
            PlaySFX(fxFail);
        }
    }

    public void BuyFoodForKid()
    {
        if (Infor.instance_Infor.m_Coin >= m_Price)
        {
            PlaySFX(fxSucces);
            Infor.instance_Infor.m_Coin -= m_Price;
            float Temp_Hungry = Infor.instance_Infor.m_ChildCurrentHungry + m_Hungry;
            float Temp_Stress = Infor.instance_Infor.m_ChildCurrentStrees - m_Stress;
            if (Temp_Hungry > Infor.instance_Infor.m_ChildMaxHungry)
            {
                Infor.instance_Infor.m_ChildCurrentHungry = Infor.instance_Infor.m_ChildMaxHungry;
            }
            else
            {
                Infor.instance_Infor.m_ChildCurrentHungry = Temp_Hungry;
            }

            if (Temp_Stress < 0)
            {
                Infor.instance_Infor.m_ChildCurrentStrees = 0;
            }
            else
            {
                Infor.instance_Infor.m_ChildCurrentStrees = Temp_Stress;
            }
        }
        else
        {
            PlaySFX(fxFail);
        }
    }    
        
}
