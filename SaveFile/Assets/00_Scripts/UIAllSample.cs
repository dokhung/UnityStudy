using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;
using Slider = UnityEngine.UI.Slider;
using Toggle = UnityEngine.UI.Toggle;

public class UIAllSample : MonoBehaviour
{
    public ScrollView scollview;
    public Image[] image;
    public Dropdown dropdwon;
    public GameObject newprefab;

    public Sprite[] sprites;
    private List<GameObject> imgobj = new List<GameObject>();
    public Button[] button; //내가 원하는 버튼들을 연결 시켜둠.   
    //public Toggle toggle;
    public Toggle[] toggles;

    public InputField inputfield;
    public Slider slider;
    int hp = 100;

    Coroutine cor = null;

    public GameObject buttonPrefab; //원본 프리팹
    public Transform Tr;
    public Transform Tr2;
    void Start()
    {
        GameObject obj = Instantiate(buttonPrefab, Tr); //        
        obj.GetComponent<Button>().onClick.AddListener(ButtonClick);



        button[0].onClick.AddListener(ButtonClick);//        

        //string inputval = inputfield.text;
        slider.maxValue = hp;
        
        GameObject makeprefab = Instantiate(newprefab,Tr2);
        makeprefab.GetComponent<Image>().sprite = sprites[0] ;
        imgobj.Add(makeprefab);
        
        makeprefab = Instantiate(newprefab,Tr2);
        makeprefab.GetComponent<Image>().sprite = sprites[1] ;
        imgobj.Add(makeprefab);
        makeprefab = Instantiate(newprefab,Tr2);
        makeprefab.GetComponent<Image>().sprite = sprites[2] ;
        imgobj.Add(makeprefab);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow)) //아래방향키
        {
            hp -= 10;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow)) //위 방향키
        {
            hp += 10;
        }
        slider.value = hp;

        
        
    }
    /*
     *public GameObject buttonPrefab; //원본 프리팹
    public Transform Tr;
    void Start()
    {
        GameObject obj = Instantiate(buttonPrefab, Tr); //        
        obj.GetComponent<Button>().onClick.AddListener(ButtonClick);



        button[0].onClick.AddListener(ButtonClick);//        

        //string inputval = inputfield.text;
        slider.maxValue = hp;

        
    }
     * 
     */

    public void GetInputField()
    {
        Debug.Log("사용자가 입력한 내용 : "+inputfield.text);
    }

    public void ImgArrClick()
    {
        
        
        // Debug.Log("dropdwon.value"+dropdwon.value);
        for (int i = 0; i < imgobj.Count; i++)
        {
            
            if (i == dropdwon.value)
            {
                imgobj[i].SetActive(true);
                
            }
            else
            {
                imgobj[i].SetActive(false);
            }
        }
        // for (int i = 0; i <= dropdwon.l; i++)
        // {
        //     Debug.Log($"dropdwon.Length : {dropdwon.Length}");
        //     image[i].gameObject.SetActive(true);
        // }
    }

    public void ToggleClick()
    {
        //Debug.Log(toggle.isOn? "토글이 체크된 상태 " : "토글이 체크 해제된 상태");
        for (int i = 0; i < toggles.Length; i++)
        {
            Debug.Log(toggles[i].isOn?  $"{i}번째 토글이 눌려있습니다" : $"{i}번째 토글 해제상태" );
        }
    }

    public void ButtonClick() //버튼에 연결시켜줄 기능.
    {
        Debug.Log("버튼이 클릭됐고 매개변수 없는 함수" );
    }
    public void ButtonClick(string a) //버튼에 연결시켜줄 기능.
    {
        Debug.Log("버튼이 클릭됐고 매개변수로 " + a + "가 들어왔음");

        //코루틴 실행
        if (cor == null)
        {
            loop = true;
            cor = StartCoroutine(CoroutineName(10));
        }

        //코루틴 멈추기
        loop = false;
        StopCoroutine( cor);
        cor = null;
    }

    bool loop = true;

    IEnumerator CoroutineName(int val /*필요하다면 매개변수 가능*/)
    {
        int i = 0;
        while (loop)
        {
            Debug.Log("코루틴 불림");
            yield return new WaitForSeconds(1f); //1초 후에 뭘 할수잇음..
            Debug.Log("코루틴 1초후 ");            
        }        

        cor = null;
    }
}
