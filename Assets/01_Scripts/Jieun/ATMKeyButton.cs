using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATMKeyButton : MonoBehaviour
{

    public void Button1(){

        Debt.Instance.inputStack.Push(1);
        


    }

    public void Del(){

    }

    public void Enter(){
        
        if(Debt.Instance.inputStack.Count == 0){

            Debug.Log("아무것도 입력하지 않았어요");
        }
        else{

            for(int i = 0; i < Debt.Instance.inputStack.Count; i++){

                Debt.Instance.inputMoney += Debt.Instance.inputStack.Pop() * (int)Mathf.Pow(10, i);
            }
        }

        Debug.Log(Debt.Instance.inputMoney);


        Debt.Instance.DebtCheck();
    }
    
}
