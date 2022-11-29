using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class RestaurantUpgrade : MonoBehaviour
{
    public NamBi _namBi;

    int res_Level2UpgradePrice = 100000;
    int res_Level3UpgradePrice = 500000;

    public Button res_level2Button;
    public Button res_level3Button;

    public GameObject errorPanel;

    public TextMeshProUGUI priceText;

    public TextMeshProUGUI moneyTxt;


    private void Update() {
        //_namBi = GameObject.Find("NamBi(Clone)").GetComponent<NamBi>();
        // _namBi = Resources.Load<GameObject>($"NamBi").GetComponent<NamBi>();

        moneyTxt.text = $"돈 : {GameManager.Instance.Money} 원";
    }

    private void Start() {
        res_level3Button.interactable = false;
        priceText.text = $"{res_Level2UpgradePrice.ToString()} 원";
    }

    public void Level2(){

        if(GameManager.Instance.Money >= res_Level2UpgradePrice){

            _namBi.upLevel = 1500;
            GameManager.Instance.Money -= res_Level2UpgradePrice;
            res_level2Button.interactable = false;
            res_level3Button.interactable = true;
            priceText.text = $"{res_Level3UpgradePrice.ToString()} 원";
        }
        else{

            errorPanel.SetActive(true);
            ShakePanel();
        }
    }

    public void Level3(){
        
        if(GameManager.Instance.Money >= res_Level3UpgradePrice){

            _namBi.upLevel = 2000;
            GameManager.Instance.Money -= res_Level3UpgradePrice;
            res_level3Button.interactable = false;
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
