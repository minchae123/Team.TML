using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class StartUIManager : MonoBehaviour
{
    int ClickCount = 0;


    public GameObject move1;
    public GameObject move2;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ClickCount++;
            if (!IsInvoking("DoubleClick"))
                Invoke("DoubleClick", 1.0f);

        }
        else if (ClickCount == 2)
        {
            CancelInvoke("DoubleClick");
            Application.Quit();
        }
    }

    public void DoubleClick()
    {
        ClickCount = 0;
    }

    public void SceneMove()
    {
        SceneManager.LoadScene(1);
    }
}
