using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonScript : MonoBehaviour
{
    static SingletonScript InstanceSing;
    private void Awake()
    {
        if(InstanceSing ==null)
        {
            InstanceSing = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
