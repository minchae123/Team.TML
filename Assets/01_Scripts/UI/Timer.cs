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
    public float time;

    public GameObject store;

    private void Start()
    {
        oritime = time;
    }

    private void Update()
    {
        TimerGo();
    }

    public void TimeSet()
    {
        time = oritime;
    }

    public void TimerGo()
    {
        time -= Time.deltaTime;
        timer.text = $"???? ?ð? : {string.Format("{0:0.0#}", time)}";

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