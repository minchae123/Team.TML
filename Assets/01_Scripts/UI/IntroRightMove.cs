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
    public string infoText2 = "마라탕집에서 맛있게 마라탕을 먹다가 자신에게 빚이 있다는 것을 알아챈다. 마라탕 결재도 할 수 없는 상황이다.";
    [TextArea]
    public string infoText3 = "그 사정을 들은 마라탕 가게 사장님은 마라탕 가게에서 일을 하라고 제안한다.";
    [TextArea]
    public string infoText4 = "제안을 받고 탕라마는 마라탕 가게에서 일하기로 한다 ! 마라탕 가게에서 일어나는 이야기 시작합니다 !";
    
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
