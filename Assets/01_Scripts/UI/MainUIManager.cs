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

    public UnityEvent nightEvent;

    private void Awake()
    {
        setting = transform.Find("Settingbtn").GetComponent<Button>();
        right = transform.Find("Rightbtn").GetComponent<Button>();
        left = transform.Find("Leftbtn").GetComponent<Button>();

        //timeTxt = transform.Find("Image").Find("TimeTxt").GetComponent<Text>();
       // moneyTxt = transform.Find("Image").Find("MoneyTxt").GetComponent<Text>();

        setting.onClick.AddListener(() => SettingBtn());
        left.onClick.AddListener(() => LeftBtn());
        right.onClick.AddListener(() => RightBtn());
    }

    private void Start()
    {
        StartCoroutine(TimeAdd());
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
        Debug.Log(3);
    }

    public void SetMoney(int money)
    {
        moneyTxt.text = string.Format("돈 : {0:#,###}", money);
    }

    public void SetTime(int time)
    {
        int h = time / 6;
        int m = time % 6;
        m = m * 10;
        timeTxt.text = string.Format("시간 = {0} : {1} {2}", h, m == 0 ? "00" : m.ToString(), h > 12 ? "PM" : "AM");

        if(h == 20 && m == 0)
        {
            nightEvent.Invoke();
        }
    }

    IEnumerator TimeAdd()                                             
    {                                                                 
        int time = 0;                                                 
        while(time < 144)                                                
        {                                                                
            yield return new WaitForSeconds(1);                          
            time++;                                                      
            SetTime(time);                                               
        }
    }
}
