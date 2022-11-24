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

        InputView(0);
    }

    public void Del(){
        viewString = viewString.Substring(0, viewString.Length - 1);
        Debt.Instance.numText.text = viewString;
    }

    public void Enter(){

        if(viewString == null || viewString == ""){

            Debt.Instance.inputMoney = 0;
            Debt.Instance.numText.text = "입력해주세요";
            Debt.Instance.ShakeCamera();
        }
        else{

            Debt.Instance.inputMoney = int.Parse(viewString);
            viewString = null;
            Debt.Instance.numText.text = viewString;
            Debt.Instance.DebtCheck();
        }

    }

    private void Start() {
        
        viewString = null;
    }

    public string viewString;
    public void InputView(int button){
        
        viewString += button.ToString();
        
        Debt.Instance.numText.text = viewString;
        
    }

    
}
