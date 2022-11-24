using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class Debt : MonoBehaviour
{   
    public static Debt Instance = null;

    private int startDebt = 50000000;
    private int currentDebt;
    public int inputMoney;

    public TextMeshProUGUI numText;
    public TextMeshProUGUI debtText;
    
    public Camera mainCamera;
    public GameObject panel;

    private void Awake() {
        
        if (Instance == null)
        {
            Instance = this;
        }  

        
    }
    
    private void Start() {
        
        currentDebt = startDebt;
        debtText.text = currentDebt.ToString();
        
    }

    public void DebtCheck(){

        debtText.text = currentDebt.ToString();
        
        if(inputMoney < GameManager.Instance.Money){
            
            currentDebt -= inputMoney;
            debtText.text = currentDebt.ToString();
            GameManager.Instance.Money -= inputMoney;
        }
        else{

            inputMoney = 0;
            numText.text = "돈 부족";
            ShakeCamera();
            
        }

        inputMoney = 0;
    }

    public void ShakeCamera(){

        panel.transform.DOShakePosition(1f, 10);
    }
}
