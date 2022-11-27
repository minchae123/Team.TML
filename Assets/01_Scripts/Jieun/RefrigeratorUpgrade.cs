using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class RefrigeratorUpgrade : MonoBehaviour
{
    private int refUpgradePrice = 100000;
    public Button ref_levelUpButton;
    public GameObject errorPanel;

    private Inverntory inventory;

    private void Awake() {
        inventory = GameObject.Find("StoreCanvas").GetComponent<Inverntory>();
    }
    public void UpgradeButtonClick(){

        if(GameManager.Instance.Money > refUpgradePrice){

            inventory.AddSlot();
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
