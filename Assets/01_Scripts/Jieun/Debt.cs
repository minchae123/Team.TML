using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Debt : MonoBehaviour
{   

    public static Debt Instance = null;

    private int startDebt = 50000000;
    private int currentDebt;
    public int inputMoney;

    public TextMeshProUGUI numText;

    private void Awake() {
        
        if (Instance == null)
        {
            Instance = this;
        }  
    }
    
    private void Start() {
        
        currentDebt = startDebt;
    }

    public void DebtCheck(){
        
        if(inputMoney < GameManager.Instance.Money){
            
            currentDebt -= inputMoney;
        }
        else if(inputMoney == 0){

            numText.text = "입력해주세요";
        }
        else{

            numText.text = "입력한 돈이 소지한 돈보다 많아요!";
        }

        inputMoney = 0;
    }
}
