using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class NightUI : MonoBehaviour
{   
    private Vector3 originalTransform;
    public Image fadeImage;
    public GameObject shutter;
    public GameObject receipt;
    public GameObject debtCanvas;
    public TextMeshProUGUI receiptText_Day;
    public TextMeshProUGUI receiptText_Calculate;
    public GraphicRaycaster graphicRaycaster;
    private MainUIManager mainUIManager;

    private void Awake() {
        mainUIManager = GameObject.Find("MainCanvas").GetComponent<MainUIManager>();
        graphicRaycaster.enabled = false;
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.F)){
            NightFade();
        }
    }

    public void NightFade(){
        
        Sequence fadeSequence = DOTween.Sequence();
        
        fadeImage.enabled = true;
        GameManager.Instance.Clear();
        fadeSequence.Append(fadeImage.DOFade(1f, 2f));
        
        fadeSequence.OnComplete(() => {
            ShutterDown();
        });  
    }

    public void ShutterDown(){

        originalTransform = shutter.transform.position;

        Sequence ShutterSequence = DOTween.Sequence();
        ShutterSequence.Append(shutter.transform.DOMove(Vector3.zero, 1.5f));
        
        ShutterSequence.OnComplete(() => {
            Receipt();
        });

    }

    public void Receipt(){
        graphicRaycaster.enabled = true;
        receiptText_Day.text = $"{GameManager.Instance.Day}일차";
        receiptText_Calculate.text = $"오늘의 수익\n{GameManager.Instance.TOMoney.ToString()}";
        receipt.transform.DOMove(Vector3.zero, 0.5f);
        GameManager.Instance.Day++;

    }

    public void ReceiptButtonClick(){

        Sequence moveOrigin = DOTween.Sequence();

        moveOrigin.Append(shutter.transform.DOMove(originalTransform, 0.5f));
        moveOrigin.Append(receipt.transform.DOMove(originalTransform, 0.5f));
        
        moveOrigin.OnComplete(() => {
            
            debtCanvas.SetActive(true);
            graphicRaycaster.enabled = false;   
        });
    }

    public void DebtButtonClock(){

        debtCanvas.SetActive(false);
        GameManager.Instance.StartDay();

        Sequence debt = DOTween.Sequence();
        debt.Append(fadeImage.DOFade(0, 1f));

        debt.OnComplete(() => {
            
            fadeImage.enabled = false;
        });
        
    }

}
