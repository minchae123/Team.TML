using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class GasrangeUpgrade : MonoBehaviour
{   
    int gas_Level2UpgradePrice = 100000;
    int gas_Level3UpgradePrice = 500000;

    public Button gas_level2Button;
    public Button gas_level3Button;

    public GameObject errorPanel;

    public TextMeshProUGUI priceText;

    private void Start() {
        gas_level3Button.interactable = false;
        priceText.text = $"{gas_Level2UpgradePrice.ToString()} 원";
    }
    public void Level2(){

        if(GameManager.Instance.Money > gas_Level2UpgradePrice){

            Cooking.Instance.burnTime = 2;
            GameManager.Instance.Money -= gas_Level2UpgradePrice;
            gas_level2Button.interactable = false;
            gas_level3Button.interactable = true;
            priceText.text = $"{gas_Level3UpgradePrice.ToString()} 원";
        }
        else
        {


            errorPanel.SetActive(true);

            ShakePanel();
        }

    }

    public void Level3(){
        
        if(GameManager.Instance.Money > gas_Level3UpgradePrice){

            Cooking.Instance.burnTime = 3;
            GameManager.Instance.Money -= gas_Level3UpgradePrice;
            gas_level3Button.interactable = false;
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
