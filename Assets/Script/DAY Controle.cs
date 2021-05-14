using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DAYControle : MonoBehaviour
{

    public TextMeshProUGUI text;

    public GameObject Endgame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Day: " +Infor.instance_Infor.Days.ToString() ;
        if(text.text == "12")
        {

            Infor.instance_Infor.EndGame = true;
            Endgame.SetActive(true);
        }
    }
}
