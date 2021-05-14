using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowEMP : MonoBehaviour
{
    public Sprite[] m_sprite;
    public Image SeftSprite;

    private void Start()
    {
        SeftSprite = GetComponent<Image>();
    }
    private void OnEnable()
    {
        SeftSprite = GetComponent<Image>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Infor.instance_Infor.m_hire == Infor.Skill_emp.Play)
        {
            SeftSprite.sprite = m_sprite[0];
        }
        else if (Infor.instance_Infor.m_hire == Infor.Skill_emp.Feed)
        {
            SeftSprite.sprite = m_sprite[1];
        }
        else if (Infor.instance_Infor.m_hire == Infor.Skill_emp.Clean)
        {
            SeftSprite.sprite = m_sprite[2];
        }
        else if (Infor.instance_Infor.m_hire == Infor.Skill_emp.All)
        {
            SeftSprite.sprite = m_sprite[3];
        }
        else
        {
            SeftSprite.sprite = m_sprite[4];
        }
    }
}
