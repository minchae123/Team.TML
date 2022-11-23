using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATMKeyButton : MonoBehaviour
{

    public void Button1(){

        InputView(1);
    }
    public void Button2(){

        InputView(2);
    }
    public void Button3(){

        InputView(3);
    }
    public void Button4(){

        InputView(4);
    }
    public void Button5(){

        InputView(5);
    }
    public void Button6(){

        InputView(6);
    }
    public void Button7(){

        InputView(7);
    }
    public void Button8(){

        InputView(8);
    }
    public void Button9(){

        InputView(9);
    }
    public void Button0(){

        Debt.Instance.numText.text = (Debt.Instance.inputMoney * 10).ToString();
    }

    public void Del(){

    }

    public void Enter(){
        
        Debt.Instance.DebtCheck();
    }

    List<int> inputLength = new List<int>();
    int input;
    public void InputView(int button){

        input = button;
        input *= (int) Mathf.Pow(10, inputLength.Count);
        inputLength.Add(input);
        Debt.Instance.inputMoney += input;
        Debt.Instance.numText.text = Debt.Instance.inputMoney.ToString();
        
    }

    
}
