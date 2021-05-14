using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStageRoom : MonoBehaviour
{
    public void ShowHideOBJ(GameObject ObjHide, GameObject ObjShow)
    {
        ObjHide.SetActive(false);
        ObjShow.SetActive(true);
    }


}
