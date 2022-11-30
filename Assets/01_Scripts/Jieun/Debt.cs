using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class Debt : MonoBehaviour
{   
    public static Debt Instance = null;

    private int startDebt = 10000000;
    private int currentDebt;
    public int inputMoney;

    public TextMeshProUGUI numText;
    public TextMeshProUGUI debtText;

    public TextMeshProUGUI moneyTxt;
    
    public GameObject panel;

    private void Awake() {
        
        if (Instance == null)
        {
            Instance = this;
        }  

        
    }
    
    private void Start() {
        currentDebt = startDebt;
        //debtText.text = currentDebt.ToString();
        debtText.text = string.Format("{0:#,###}", currentDebt);
        moneyTxt.text = $"돈 : {GameManager.Instance.Money}원";
    }

    private void Update()
    {
        moneyTxt.text = $"돈 : {GameManager.Instance.Money}원";
        //debtText.text = string.Format("{0:#,###}", currentDebt);

        if (currentDebt <= 0)
        {
            SceneManager.LoadScene(2); 
        }
    }

    public void DebtCheck(){

        debtText.text = currentDebt.ToString();
        debtText.text = string.Format("{0:#,###}", currentDebt);
        
        if(inputMoney < GameManager.Instance.Money){
            
            currentDebt -= inputMoney;
            //debtText.text = currentDebt.ToString();
            debtText.text = string.Format("{0:#,###}", currentDebt);
            GameManager.Instance.Money -= inputMoney;
        }
        else{

            inputMoney = 0;
            numText.text = "돈 부족";
            ShakePanel();
            
        }

        inputMoney = 0;
    }

    public void ShakePanel(){

        panel.transform.DOShakePosition(1f, 10);
    }
}
