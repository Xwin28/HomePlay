using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class WorkTaps : MonoBehaviour
{
    private int _numberClick;
    public Slider _slider;


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
    private void OnEnable()
    {
        if (GetComponent<AudioSource>())
            Sourcesfx = GetComponent<AudioSource>();
        _numberClick =0;
    }
    void OnMouseDown()
    {

        if(Infor.instance_Infor.m_PlayerCurrentStrees  <99.9f)
        {
            PlaySFX();
            Infor.instance_Infor.m_Coin += Infor.instance_Infor.rewardTaps;
            _numberClick++;
            Debug.Log("Infor.instance_Infor.Days = " + Infor.instance_Infor.Days);

            if (Infor.instance_Infor.rewardTaps == 10)
            {
                _slider.value += 0.1f;
            }

            switch (Infor.instance_Infor.Days)
            {

                case 1:
                case 2:
                case 3:
                case 4:
                    Debug.Log("Number Click = " + _numberClick);
                    Infor.instance_Infor.m_PlayerCurrentStrees += 1;
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                    Infor.instance_Infor.m_PlayerCurrentStrees += 2;
                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                    Infor.instance_Infor.m_PlayerCurrentStrees += 3;
                    break;

            }
            if (Infor.instance_Infor.m_PlayerCurrentHungry > Infor.instance_Infor.m_PlayerMaxStrees)
            {
                Infor.instance_Infor.m_PlayerCurrentStrees = Infor.instance_Infor.m_PlayerMaxStrees;
            }

            if (_numberClick >= 7)
            {

                _numberClick = 0;
                switch (Infor.instance_Infor.Days)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Infor.instance_Infor.m_PlayerCurrentHungry -= 2;
                        Infor.instance_Infor.m_PlayerCurrentStrees += 1;
                        break;
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        Infor.instance_Infor.m_PlayerCurrentHungry -= 3;
                        Infor.instance_Infor.m_PlayerCurrentStrees += 2;
                        break;
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                        Infor.instance_Infor.m_PlayerCurrentHungry -= 5;
                        Infor.instance_Infor.m_PlayerCurrentStrees += 3;
                        break;

                }
                if (Infor.instance_Infor.m_PlayerCurrentHungry < 0)
                {
                    Infor.instance_Infor.m_PlayerCurrentHungry = 0;
                }

            }
        }
        
    }
}
