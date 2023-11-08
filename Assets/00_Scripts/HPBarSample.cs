using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBarSample : MonoBehaviour
{
    public Slider slider;
    private int HP = 100;
    private int MaxHP = 100;
    public int Damage = 10;
    public Image CollImg;

    private void Start()
    {
        HP = MaxHP;
        slider.maxValue = MaxHP;
        slider.value = MaxHP;
    }

    private void Update()
    {
        // CollImg.fillAmount = 5.5f;
        if (Input.GetKey(KeyCode.W))
        {
            CollImg.fillAmount -= 0.05f;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            HP -= Damage;
            slider.value = HP;
        }
        else if(Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            MaxHP += 100;
            slider.maxValue = MaxHP;
            HP += 100;
            slider.value = HP;
        }
    }
}
