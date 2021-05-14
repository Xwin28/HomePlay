using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GetInfor : MonoBehaviour
{
    [System.Serializable]
    public enum TypeOfCheck {Coin, Health, Hungry, Stress, HealthKid, HungryKid, StressKid }
    public TypeOfCheck m_type;
    private TextMeshProUGUI m_text;
    private Infor m_infor;

    private Slider m_slider;
    // Start is called before the first frame update
    void Start()
    {
        m_infor = Infor.instance_Infor;
        switch (m_type)
        {
            case TypeOfCheck.Coin:
                if(GetComponent<TextMeshProUGUI>())
                {
                    m_text = GetComponent<TextMeshProUGUI>();
                    m_text.SetText(m_infor.m_Coin.ToString());
                }
                break;
            case TypeOfCheck.Health:
                if(GetComponent<Slider>())
                {
                    m_slider = GetComponent<Slider>();
                    m_slider.value =  m_infor.m_PlayerCurrenthealth / m_infor.m_PlayerMaxhealth;
                }
                break;
            case TypeOfCheck.Hungry:
                if (GetComponent<Slider>())
                {
                    m_slider = GetComponent<Slider>();
                    m_slider.value =  m_infor.m_PlayerCurrentHungry / m_infor.m_PlayerMaxHungry;
                }
                break;
            case TypeOfCheck.Stress:
                if (GetComponent<Slider>())
                {
                    m_slider = GetComponent<Slider>();
                    m_slider.value = m_infor.m_PlayerCurrentStrees / m_infor.m_PlayerMaxStrees;
                }
                break;
            case TypeOfCheck.HealthKid:
                if (GetComponent<Slider>())
                {
                    m_slider = GetComponent<Slider>();
                    m_slider.value = m_infor.m_ChildCurrenthealth / m_infor.m_ChildMaxhealth;
                }
                break;
            case TypeOfCheck.HungryKid:
                if (GetComponent<Slider>())
                {
                    m_slider = GetComponent<Slider>();
                    m_slider.value = m_infor.m_ChildCurrentHungry / m_infor.m_ChildMaxHungry;
                }
                break;
            case TypeOfCheck.StressKid:
                if (GetComponent<Slider>())
                {
                    m_slider = GetComponent<Slider>();
                    m_slider.value = m_infor.m_ChildCurrentStrees / m_infor.m_ChildMaxStrees;
                }

                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (m_type)
        {
            case TypeOfCheck.Coin:
                if (GetComponent<TextMeshProUGUI>())
                {
                    m_text = GetComponent<TextMeshProUGUI>();
                    m_text.SetText(m_infor.m_Coin.ToString());
                }
                break;
            case TypeOfCheck.Health:
                if (GetComponent<Slider>())
                {
                    m_slider = GetComponent<Slider>();
                    m_slider.value = m_infor.m_PlayerCurrenthealth / m_infor.m_PlayerMaxhealth;
                }
                break;
            case TypeOfCheck.Hungry:
                if (GetComponent<Slider>())
                {
                    m_slider = GetComponent<Slider>();
                    m_slider.value = m_infor.m_PlayerCurrentHungry / m_infor.m_PlayerMaxHungry;
                }
                break;
            case TypeOfCheck.Stress:
                if (GetComponent<Slider>())
                {
                    m_slider = GetComponent<Slider>();
                    m_slider.value = m_infor.m_PlayerCurrentStrees / m_infor.m_PlayerMaxStrees;
                }
                break;
            case TypeOfCheck.HealthKid:
                if (GetComponent<Slider>())
                {
                    m_slider = GetComponent<Slider>();
                    m_slider.value = m_infor.m_ChildCurrenthealth / m_infor.m_ChildMaxhealth;
                }
                break;
            case TypeOfCheck.HungryKid:
                if (GetComponent<Slider>())
                {
                    m_slider = GetComponent<Slider>();
                    m_slider.value = m_infor.m_ChildCurrentHungry / m_infor.m_ChildMaxHungry;
                }
                break;
            case TypeOfCheck.StressKid:
                if (GetComponent<Slider>())
                {
                    m_slider = GetComponent<Slider>();
                    m_slider.value = m_infor.m_ChildCurrentStrees / m_infor.m_ChildMaxStrees;
                }
                break;
        }
    }
}
