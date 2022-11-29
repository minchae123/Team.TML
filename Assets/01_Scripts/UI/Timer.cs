using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
//    public Text timer;
    public TextMeshProUGUI timer;
    public float oritime;
    public float time = 20f;

    public GameObject store;

    private void Start()
    {
        oritime = time;
    }

    private void Update()
    {
        if(this.gameObject)

        TimerGo();
    }

    public void TimerGo()
    {
        time -= Time.deltaTime;
        timer.text = $"상점 시간 : {string.Format("{0:0.0#}", time)}";

        if(time < 0)
        {
            store.SetActive(false);
        }

        if (time < 0)
        {
            time = oritime;
        }

    }
}