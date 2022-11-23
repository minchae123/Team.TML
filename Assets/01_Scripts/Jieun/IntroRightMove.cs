using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class IntroRightMove : MonoBehaviour
{
    public GameObject introCut;
    public GameObject introCanvas;
    public int clickCount = 1;
    private Vector3 moveVector = new Vector3(-1920, 0, 0);

    public TextMeshProUGUI infoText;

    [TextArea]
    public string infoText2 = "2번 설명입니다.";
    [TextArea]
    public string infoText3 = "3번 설명입니다.";
    [TextArea]
    public string infoText4 = "4번 설명입니다.";
    
    public void IntroButtonClick(){

        clickCount++;

        introCut.transform.DOLocalMove(introCut.transform.localPosition+ moveVector, 0.5f);

        switch(clickCount){

            case 2 :
                infoText.text = infoText2;
                break;
            case 3 :
                infoText.text = infoText3;
                break;
            case 4 :
                infoText.text = infoText4;
                break;
            case 5 :
                introCanvas.SetActive(false);
                MainUIManager a = FindObjectOfType<MainUIManager>();
                a.StartCoroutine(a.TimeAdd());
                break;

        }

    }
}
