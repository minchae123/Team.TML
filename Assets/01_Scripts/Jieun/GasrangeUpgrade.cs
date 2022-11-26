using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GasrangeUpgrade : MonoBehaviour
{   
    int gas_Level2UpgradePrice;
    int gas_Level3UpgradePrice;

    public Button gas_level2Button;
    public Button gas_level3Button;
    public void Level2(){

        if(GameManager.Instance.Money > gas_Level2UpgradePrice){

            Cooking.Instance.burnTime = 2;
            GameManager.Instance.Money -= gas_Level2UpgradePrice;
            gas_level2Button.interactable = false;
        }
        
    }

    public void Level3(){
        
        if(GameManager.Instance.Money > gas_Level3UpgradePrice){

            Cooking.Instance.burnTime = 3;
            GameManager.Instance.Money -= gas_Level3UpgradePrice;
            gas_level3Button.interactable = false;
        }
    }
}
