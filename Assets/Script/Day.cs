using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Day : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject GameOver;
    public GameObject Endgame;
    public GameObject PanelCoin, PanelInfor, PanelChangeRoom;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Day: " + Infor.instance_Infor.Days.ToString();
        if (Infor.instance_Infor.Days>= 12)
        {
            PanelChangeRoom.SetActive(false);
            PanelCoin.SetActive(false);
            PanelInfor.SetActive(false);
            Infor.instance_Infor.EndGame = true;
            Endgame.SetActive(true);
        }

        if(Mathf.Abs( Infor.instance_Infor.m_PlayerCurrenthealth - Infor.instance_Infor.m_PlayerMaxhealth) > 99.9f ||
            Mathf.Abs(Infor.instance_Infor.m_ChildCurrenthealth - Infor.instance_Infor.m_ChildMaxhealth) > 99.9f)
        {
           
            PanelChangeRoom.SetActive(false);
            PanelCoin.SetActive(false);
            PanelInfor.SetActive(false);
            Infor.instance_Infor.EndGame = true;
            GameOver.SetActive(true);
}
    }
}
