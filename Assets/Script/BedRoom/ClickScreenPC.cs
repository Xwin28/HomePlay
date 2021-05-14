using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickScreenPC : MonoBehaviour
{
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

    public GameObject BedRoomHide;
    public GameObject[] BedRoomShow;
    private bool IsChangeSizeCam = false;
    private bool IsDoneCam;
    public void Update()
    {

        if(IsChangeSizeCam)
        {

            Camera.main.orthographicSize -= 5 * Time.deltaTime;
            if (Camera.main.orthographicSize <=2)
            {
                IsChangeSizeCam = false;
                BedRoomHide.SetActive(false);
                for( int i =0;i<BedRoomShow.Length;i++)
                {
                    BedRoomShow[i].SetActive(true);
                    Camera.main.orthographicSize = 3;
                }
                

            }
        }

    }

    void OnMouseDown()
    {
        PlaySFX();
        // this object was clicked - do something
        IsChangeSizeCam = true;
        
    }
}
