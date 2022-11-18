using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class NightUI : MonoBehaviour
{
    public Image fadeImage;
    public GameObject shutter;


    private void Update() {
        if(Input.GetKeyDown(KeyCode.F)){
            Debug.Log("키 입력");
            NightFade();
        }
    }

    public void NightFade(){
        
        Sequence fadeSequence = DOTween.Sequence();

        fadeImage.enabled = true;
        Debug.Log("페이드실행");
        fadeSequence.Append(fadeImage.DOFade(1f, 2f));
        
        fadeSequence.OnComplete(() => {
            //fadeImage.DOFade(0,0.1f);
            Debug.Log("온컴플리트");
            ShutterDown();
        });

        
    }

    public void ShutterDown(){
        Debug.Log("셔터다운");

        Sequence ShutterSequence = DOTween.Sequence();

        ShutterSequence.Append(shutter.transform.DOMove(Vector3.zero, 1.5f));
        

    }

    public void Calculate(){
        
    }
}
