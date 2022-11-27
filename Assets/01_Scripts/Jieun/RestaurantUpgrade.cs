using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class RestaurantUpgrade : MonoBehaviour
{
    private NamBi _namBi;

    int res_Level2UpgradePrice = 100000;
    int res_Level3UpgradePrice = 500000;

    public Button res_level2Button;
    public Button res_level3Button;

    public GameObject errorPanel;

    private void Awake() {
        _namBi = GameObject.Find("DroppableUI").GetComponent<NamBi>();
    }

    private void Start() {
        res_level3Button.interactable = false;
    }
    public void Level2(){

        if(GameManager.Instance.Money > res_Level2UpgradePrice){

            _namBi.upLevel = 2;
            GameManager.Instance.Money -= res_Level2UpgradePrice;
            res_level2Button.interactable = false;
            res_level3Button.interactable = true;
        }
        else{

            errorPanel.SetActive(true);
            ShakePanel();
            errorPanel.SetActive(false);
        }
    }

    public void Level3(){
        
        if(GameManager.Instance.Money > res_Level3UpgradePrice){

            _namBi.upLevel = 3;
            GameManager.Instance.Money -= res_Level3UpgradePrice;
            res_level3Button.interactable = false;
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
