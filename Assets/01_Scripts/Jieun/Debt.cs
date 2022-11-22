using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debt : MonoBehaviour
{
    private int startDebt = 50000000;
    private int currentDebt;
    private int inputMoney;
    
    private void Start() {
        
        currentDebt = startDebt;
    }
    void DebtCheck(){
        
        if(inputMoney < GameManager.Instance.Money){
            
            currentDebt -= inputMoney;
        }
        else{

            Debug.Log("입력한 돈이 소지한 돈보다 많아요!");
        }
    }
}
