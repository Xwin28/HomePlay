using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using Unity.Rendering;
public struct Worker
{
    public float m_WorkerStress;
    public float m_WorkerSkill; // Nang Suat
    public float m_WorkerAsk;
}

public class Infor : MonoBehaviour
{
    public enum Skill_emp { Play, Feed, Clean, All, Nothing }
    public int Days =1;
    public static Infor instance_Infor;
    public EntityManager entityManager;
    public bool EndGame;

    public int rewardTaps;
    public double m_Coin;
    public float m_PlayerCurrenthealth;// = 0 -> death (Increase when Full Hunbgry)
    public float m_PlayerMaxhealth;// = 0 -> death (Increase when Full Hunbgry)
    public float m_PlayerCurrentStrees;// full will not able to work
    public float m_PlayerMaxStrees;// full will not able to work
    public float m_PlayerCurrentHungry;// <=0 will lose Health ( l0se faster when work )
    public float m_PlayerMaxHungry;// <=0 will lose Health ( l0se faster when work )


    [Header("Child")] 
    public float m_ChildCurrenthealth;// = 0 -> death (Increase when Full Hunbgry)
    public float m_ChildMaxhealth;// = 0 -> death (Increase when Full Hunbgry)

    public float m_ChildCurrentStrees;// full will not able to work
    public float m_ChildMaxStrees;// full will not able to work

    public float m_ChildCurrentHungry;// <=0 will lose Health ( l0se faster when work )
    public float m_ChildMaxHungry;// <=0 will lose Health ( l0se faster when work )

    public bool m_ChildDirty;

    [Header("Hired")]
    public Skill_emp m_hire;

    // There are 8 workers
    private void Awake()
    {
        EndGame = false;

        rewardTaps = 10;
        if(instance_Infor == null)
        {
            instance_Infor = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
        entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
    }


    private int time;
    private int timekid;
    // Update is called once per frame
    void Update()
    {

        if (!EndGame)
        {
            if(m_PlayerCurrentStrees>0)
            {
                m_PlayerCurrentStrees -= Time.deltaTime * 2f;
            }
            if (m_PlayerCurrentHungry > 0)
            {
                m_PlayerCurrentHungry -= Time.deltaTime * .5f;
            }


            #region Hoi mau neu no
            if (m_PlayerCurrenthealth < m_PlayerMaxhealth &&
                m_PlayerCurrentHungry > (m_PlayerMaxHungry / 2))
            {

                m_PlayerCurrenthealth += .5f * Time.deltaTime;
            }

            if (m_ChildCurrenthealth < m_ChildMaxhealth &&
             m_ChildCurrentHungry > (m_ChildMaxHungry / 2))
            {

                m_ChildCurrenthealth += .5f * Time.deltaTime;
            }

            #endregion
            #region Tru mau neu Doi
            if (m_PlayerCurrentHungry <= 0.1f)
            {
                if (m_PlayerCurrenthealth >= 0.1)
                    m_PlayerCurrenthealth -= 1 * Time.deltaTime;
            }

            if (m_ChildCurrentHungry <= 0.1f)
            {
 
                if (m_ChildCurrenthealth >= 0.1f)
                    m_ChildCurrenthealth -= 1 * Time.deltaTime;
            }
            #endregion
            ShowHurtwithSHIT();
            if (Time.time > time)
            {
                time += 50;
                Days += 1;
                m_hire = Skill_emp.Nothing;
                if (Days >= 12)
                {
                    //Win
                }
            }

            if (m_hire == Skill_emp.Play)
            {
                SlowHungyKid();

            }
            else if (m_hire == Skill_emp.Feed)
            {
                SlowBorderKid();
            }
            else if (m_hire == Skill_emp.Clean)
            {
                SlowHungyKid();
                SlowBorderKid();
            }
            else if (m_hire == Skill_emp.Nothing)
            {
                SlowHungyKid();
                SlowBorderKid();
            }


            if (Time.time > timekid)
            {
                timekid += UnityEngine.Random.Range(10, 30);
                m_ChildCurrentHungry -= UnityEngine.Random.Range(10, 30);
            }


            /*        #region Slowly hungy
                    if (m_ChildCurrentHungry >0)
                    {
                        m_ChildCurrentHungry -= 1 * Time.deltaTime;
                    }
                    else
                    {
                        m_ChildCurrentHungry = 0;
                    }
                    #endregion*/

        }
    }

    public float test;
    public void SlowHungyKid()
    {
        #region Slowly hungy
        if (m_ChildCurrentHungry > 0)
        {
            m_ChildCurrentHungry -= (float)Days/test * Time.deltaTime;
        }
        else
        {
            m_ChildCurrentHungry = 0;
        }
        #endregion
    }
    public void SlowBorderKid()
    {
        #region Slowly hungy
        if (m_ChildCurrentStrees < m_ChildMaxStrees)
        {
            m_ChildCurrentStrees += (float)Days/test * Time.deltaTime;
        }
        else
        {
            m_ChildCurrentStrees = m_ChildMaxStrees;
        }
        #endregion
    }
    public void ShowHurtwithSHIT()
    {
        if(m_ChildDirty)
        { 
                if (m_ChildCurrenthealth >= 0.1f)
                    m_ChildCurrenthealth -= .5f * Time.deltaTime; 
        }
    }

    public void IncreaseClick()
    {
        m_Coin += 10;
    }
}
