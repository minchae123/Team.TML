using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;
    public float oritime;
    public float time = 20f;

    private void Start()
    {
        oritime = time;
    }

    private void Update()
    {
        time -= Time.deltaTime;
        timer.text = string.Format("{0:0.0#}",time);

        if(time < 0)
        {
            time = oritime;
        }
    }
}