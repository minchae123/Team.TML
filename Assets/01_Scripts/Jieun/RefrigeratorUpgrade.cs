using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class RefrigeratorUpgrade : MonoBehaviour
{
    private int refUpgradePrice = 100000;
    public Button ref_levelUpButton;
    public GameObject errorPanel;

    private Inverntory inventory;

    public TextMeshProUGUI priceText;

    private void Awake() {
        inventory = GameObject.Find("StoreCanvas").GetComponent<Inverntory>();
    }

    private void Start() {
        
        priceText.text = $"{refUpgradePrice.ToString()} 원";
    }
    public void UpgradeButtonClick(){

        if(GameManager.Instance.Money > refUpgradePrice){

            inventory.AddSlot();
            GameManager.Instance.Money -= refUpgradePrice;
        }
        else{

            errorPanel.SetActive(true);
            
            ShakePanel();
        }
        
    }

    public void ShakePanel(){

        Sequence sequence = DOTween.Sequence();

        sequence.Append(errorPanel.transform.DOShakePosition(1f, 10));

        sequence.OnComplete(() => {

            errorPanel.SetActive(false);
        });
    }
}
