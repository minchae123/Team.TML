using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GasrangeUpgrade : MonoBehaviour
{   
    int gas_Level2UpgradePrice = 100000;
    int gas_Level3UpgradePrice = 500000;

    public Button gas_level2Button;
    public Button gas_level3Button;

    public GameObject errorPanel;

    private void Start() {
        gas_level3Button.interactable = false;
    }
    public void Level2(){

        if(GameManager.Instance.Money > gas_Level2UpgradePrice){

            Cooking.Instance.burnTime = 2;
            GameManager.Instance.Money -= gas_Level2UpgradePrice;
            gas_level2Button.interactable = false;
            gas_level3Button.interactable = true;
        }
        else{
            errorPanel.SetActive(true);
            ShakePanel();
            errorPanel.SetActive(false);
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
            errorPanel.SetActive(false);
        }
    }

    public void ShakePanel(){

        errorPanel.transform.DOShakePosition(1f, 10);
    }
}
