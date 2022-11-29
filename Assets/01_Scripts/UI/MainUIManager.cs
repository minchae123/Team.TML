using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class MainUIManager : MonoBehaviour
{
    private Button setting;
    private Button right;
    private Button left;

    public TextMeshProUGUI timeTxt;
    public TextMeshProUGUI moneyTxt;
    public int dayCount = 1;
    public int time = 48;

    public UnityEvent nightEvent;
    public GameObject invenUI;


    private void Awake()
    {
        setting = transform.Find("Settingbtn").GetComponent<Button>();
        right = transform.Find("Rightbtn").GetComponent<Button>();
        left = transform.Find("Leftbtn").GetComponent<Button>();

        setting.onClick.AddListener(() => SettingBtn());
        left.onClick.AddListener(() => LeftBtn());
        right.onClick.AddListener(() => RightBtn());
    }

    public void Init()
    {
        if(invenUI.activeInHierarchy == false)
        {
            invenUI.SetActive(true);
        }
        if (coroutine != null) StopCoroutine(coroutine);
        coroutine = StartCoroutine(TimeAdd());
        //StartCoroutine(TimeAdd());
    }


    private void Start()
    {
    }

    private void Update()
    {
        SetMoney(GameManager.Instance.Money);
    }

    public void LeftBtn()
    {
        Debug.Log(1);
    }
    public void RightBtn()
    {
        Debug.Log(2);
    }
    public void SettingBtn()
    {

    }

    public void SetMoney(int money)
    {
        moneyTxt.text = string.Format("돈 : {0:#,###} 원", money);
    }

    public void SetTime(int time)
    {
        int h = time / 6;
        int m = time % 6;
        m = m * 10;
        timeTxt.text = string.Format("{0}일차 {1} : {2} {3}", GameManager.Instance.Day ,h, m == 0 ? "00" : m.ToString(), h > 12 ? "PM" : "AM");

        if(h == 20 && m == 0)
        {
            nightEvent.Invoke();
            h = 1;
            m = 1;
        }

        /*if(h == 24){

            dayCount++;
        }*/
    }

    Coroutine coroutine;

    public IEnumerator TimeAdd()                                             
    {                                                                 
        while(time < 144)                                                
        {
            yield return null;
            time++;                                                      
            SetTime(time);
            yield return new WaitForSeconds(2f);                    
        }
    }
}
