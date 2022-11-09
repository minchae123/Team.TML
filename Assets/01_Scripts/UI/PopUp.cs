using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PopUp : MonoBehaviour
{
    public GameObject panel;
    public GameObject startButton;
    private Vector3 _popDownTrm = new Vector3(0, -10, 0);
    
    
    public void PopUpPanel(){
        CheckPanel();

        startButton.SetActive(false);
        panel.transform.DOMove(Vector3.zero, 1);
    }

    public void PopDownPanel(){
        CheckPanel();
        
        panel.transform.DOMove(_popDownTrm, 1);
        startButton.SetActive(true);

    }

    public void CheckPanel()
    {
        if(panel == null){
            Debug.Log("PopUp할 패널이 비어있습니다.");
        }
    }
}
