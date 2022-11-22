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
    public TextMeshProUGUI receiptText_Day;
    public TextMeshProUGUI receiptText_Calculate;
    private MainUIManager mainUIManager;
    public GraphicRaycaster graphicRaycaster;

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
            graphicRaycaster.enabled = false;
            fadeImage.enabled = false;
            mainUIManager.time = 48;
        });

    }
}
