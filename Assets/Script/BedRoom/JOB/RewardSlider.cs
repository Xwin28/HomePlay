using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardSlider : MonoBehaviour
{
    public Slider _slider;
    public float _speed;

    private void Start()
    {
        _slider = GetComponent<Slider>();
    }
    // Update is called once per frame
    void Update()
    {
        if(_slider.value > 0)
        {
            _slider.value -= _speed * Time.deltaTime;
        }

        if(  _slider.value > 0.9f)
        {
            Infor.instance_Infor.rewardTaps = 20;
        }
        else if(_slider.value <0.1f)
        {
            Infor.instance_Infor.rewardTaps = 10;
        }
    }
}
