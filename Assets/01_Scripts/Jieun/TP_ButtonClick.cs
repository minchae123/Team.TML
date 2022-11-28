using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP_ButtonClick : MonoBehaviour
{
    public GameObject tpCanvas;

    public void ButtonOnClick(){

        tpCanvas.gameObject.SetActive(true);
    }

    public void XButtonClick(){

        tpCanvas.gameObject.SetActive(false);
    }
}
