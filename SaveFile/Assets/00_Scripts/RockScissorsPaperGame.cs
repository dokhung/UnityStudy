using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockScissorsPaperGame : MonoBehaviour
{
    string[] rspString = new string[] { "보", "가위", "바위"};
    
    public Image comImg;
    public Sprite[] RSPSprites;
    
    public Text text;
    int comnum = 0;
    bool isrepeat = false;

    public GameObject Button;

    Coroutine cor = null;
    void Start()
    {        
        GameStart();
    }
    public void GameStart()
    {
        text.text = "가위바위보를 선택해주세요";
        isrepeat = true;
        if (cor == null)
        {
            cor = StartCoroutine(ImgShuffle());
        }

        Button.SetActive(false);
    }
    public void PlayerChoose(int playernum)
    {
        isrepeat = false;
        StopCoroutine(cor);
        cor = null;
        comImg.sprite = RSPSprites[comnum];
        
        if (playernum== comnum)
        {
            text.text = rspString[playernum].ToString()+"를 선택하여 비겼습니다";
        }
        else
        {
            if (playernum > comnum)
            {
                if (playernum == 2 && comnum == 0)
                {
                    text.text = rspString[playernum]+ "를 선택하여 졌습니다";
                }
                else
                {
                    text.text = rspString[playernum] + "를 선택하여 이겼습니다";
                }
            }
            else
            {
                if (playernum == 0 && comnum == 2)
                {
                    text.text = rspString[playernum]+ "를 선택하여 이겼습니다";
                }
                else
                {
                    text.text = rspString[playernum] + "를 선택하여 졌습니다";                    
                }
            }            
        }

        Button.SetActive(true);
    }
    IEnumerator ImgShuffle()
    {                
        while (isrepeat/*true*/) //간혹 코루틴을 정지시켜도 while문이 지속되는 경우가 있어서 bool을 따로주는것이 좀더 안전ㅜ
        {
            comImg.sprite = RSPSprites[comnum];
            yield return new WaitForSeconds(0.08f);
            comnum++;
            if (comnum > 2)
            {
                comnum = 0;
            }
        }        
    }
}
