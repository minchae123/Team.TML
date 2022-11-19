using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class NightUI : MonoBehaviour
{   
    public Vector3 originalTransform;
    public Image fadeImage;
    public GameObject shutter;
    public GameObject receipt;
    public TextMeshProUGUI receiptText_Day;
    public TextMeshProUGUI receiptText_Calculate;
    private MainUIManager mainUIManager;

    private void Awake() {

        mainUIManager = GameObject.Find("Canvas").GetComponent<MainUIManager>();
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.F)){
            Debug.Log("키 입력");
            NightFade();
        }
    }

    public void NightFade(){
        
        Sequence fadeSequence = DOTween.Sequence();

        fadeImage.enabled = true;
        fadeSequence.Append(fadeImage.DOFade(1f, 2f));
        
        fadeSequence.OnComplete(() => {
            
            ShutterDown();
        });

        
    }

    public void ShutterDown(){

        Debug.Log("셔터다운");

        originalTransform = shutter.transform.position;

        Sequence ShutterSequence = DOTween.Sequence();
        ShutterSequence.Append(shutter.transform.DOMove(Vector3.zero, 1.5f));
        
        ShutterSequence.OnComplete(() => {

            Receipt();
        });

    }

    public void Receipt(){

        receiptText_Day.text = $"{mainUIManager.dayCount}일차";
        //receiptText_Calculate.text =  
        receipt.transform.DOMove(Vector3.zero, 0.5f);

    }

    public void ReceiptButtonClick(){

        Sequence moveOrigin = DOTween.Sequence();

        moveOrigin.Append(shutter.transform.DOMove(originalTransform, 0.5f));
        moveOrigin.Append(receipt.transform.DOMove(originalTransform, 0.5f));
        moveOrigin.Append(fadeImage.DOFade(0, 1f));

        moveOrigin.OnComplete(() => {

            fadeImage.enabled = false;
        });

    }
}
