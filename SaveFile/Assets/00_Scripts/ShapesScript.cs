using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShapesScript : MonoBehaviour
{
    public Toggle toggleSprite1;
    public Toggle toggleSprite2;
    public Toggle toggleSprite3;
    public Toggle toggleColor1;
    public Toggle toggleColor2;
    public Toggle toggleColor3;
    public SpriteRenderer spren1;
    public SpriteRenderer spren2;
    public SpriteRenderer spren3;
    public Slider slider;
    private float min = 0;
    private float max = 1;

    private Color color;

    public Slider HPslider;
    
    

    public void Start()
    {
        // spren.color = Color.red + Color.blue;
        // spren.color = new Color(1, 1, 1, 1);
    }

    

    public void ClickedToggle()
    {
        
        
        // if (toggle.isOn)
        // {
        //     Debug.Log("토글이 선택되었음");
        // }
        // else
        // {
        //     Debug.Log("토글이 해제 되었음");
        // }

        #region 빨강
        if (toggleSprite1.isOn && toggleColor1.isOn)
        {
            Debug.Log("빨강으로 색상 변경");
            spren1.color = Color.red;
            spren1.gameObject.SetActive(true);
        }
        

        
        
        else if (toggleSprite2.isOn && toggleColor1.isOn)
        {
            Debug.Log("빨강으로 색상 변경");
            spren2.color = Color.red;
            spren2.gameObject.SetActive(true);
        }
        
        
        
        
        else if (toggleSprite3.isOn && toggleColor1.isOn)
        {
            Debug.Log("빨강으로 색상 변경");
            spren3.color = Color.red;
            spren3.gameObject.SetActive(true);
        }
        
        
        
        
        #endregion

        #region 초록
        else if (toggleSprite1.isOn && toggleColor2.isOn)
        {
            Debug.Log("초록색 색상 변경");
            spren1.color = Color.green;
            spren1.gameObject.SetActive(true);
        }
        

        
        
        else if (toggleSprite2.isOn && toggleColor2.isOn)
        {
            Debug.Log("초록색 색상 변경");
            spren2.color = Color.green;
            spren2.gameObject.SetActive(true);
        }
        
        
        
        
        else if (toggleSprite3.isOn && toggleColor2.isOn)
        {
            Debug.Log("초록색 색상 변경");
            spren3.color = Color.green;
            spren3.gameObject.SetActive(true);
        }
        
        
        
        #endregion

        #region 파랑
        else if (toggleSprite1.isOn && toggleColor3.isOn)
        {
            Debug.Log("파란색 색상 변경");
            spren1.color = Color.blue;
            spren1.gameObject.SetActive(true);
        }
        

        
        
        else if (toggleSprite2.isOn && toggleColor3.isOn)
        {
            Debug.Log("파란색 색상 변경");
            spren2.color = Color.blue;
            spren2.gameObject.SetActive(true);
        }
        
        
        
        
        else if (toggleSprite3.isOn && toggleColor3.isOn)
        {
            Debug.Log("파란색 색상 변경");
            color.r = 0;
            color.g = 0;
            color.b = 1;
            spren3.color = color;//Color.blue;
            spren3.gameObject.SetActive(true);
            
        }
        
        #endregion

        
        
    }

    public void SliderColorChanged()
    {
        color.a = slider.value;
       Debug.Log(slider.value);

       
       spren3.color = color;
    }
}
