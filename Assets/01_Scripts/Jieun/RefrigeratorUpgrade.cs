using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class RefrigeratorUpgrade : MonoBehaviour
{
    private int refUpgradePrice;
    public Button ref_levelUpButton;
    public GameObject errorPanel;

    private void Awake() {
        
    }
    public void UpgradeButtonClick(){

        if(GameManager.Instance.Money > refUpgradePrice){

            
            GameManager.Instance.Money -= refUpgradePrice;
        }
        else{

            errorPanel.SetActive(true);
            ShakePanel();
            errorPanel.SetActive(false);
        }
        
    }

    public void ShakePanel(){

        errorPanel.transform.DOShakePosition(1f, 10);
    }
}
