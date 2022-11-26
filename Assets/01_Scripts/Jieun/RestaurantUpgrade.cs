using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestaurantUpgrade : MonoBehaviour
{
    private NamBi _namBi;

    int res_Level2UpgradePrice;
    int res_Level3UpgradePrice;

    public Button res_level2Button;
    public Button res_level3Button;

    private void Awake() {
        _namBi = GameObject.Find("DroppableUI").GetComponent<NamBi>();
    }

    public void Level2(){

        if(GameManager.Instance.Money > res_Level2UpgradePrice){

            _namBi.upLevel = 2;
            GameManager.Instance.Money -= res_Level2UpgradePrice;
            res_level2Button.interactable = false;
        }   
    }

    public void Level3(){
        
        if(GameManager.Instance.Money > res_Level3UpgradePrice){

            _namBi.upLevel = 3;
            GameManager.Instance.Money -= res_Level3UpgradePrice;
            res_level3Button.interactable = false;
        }
    }
}
