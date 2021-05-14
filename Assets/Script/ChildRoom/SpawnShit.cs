using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShit : MonoBehaviour
{

    public GameObject m_SHIT;
    public GameObject gameObjectslist;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    int tempTime;
    // Update is called once per frame
    void Update()
    {
        if(!(Infor.instance_Infor.m_hire == Infor.Skill_emp.Clean))
        {
            if (Time.time > tempTime)
            {
                tempTime += UnityEngine.Random.Range(10, 20);
                Infor.instance_Infor.m_ChildDirty = true;
                gameObjectslist.SetActive(true);
                
            }

        }

    }

    public void CleanShit()
    {
        Infor.instance_Infor.m_ChildDirty = false;
        gameObjectslist.SetActive(false);
    }


}
