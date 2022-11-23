using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    StoreGoods storeGoods;

    public GameObject meatP; 
    public GameObject vegatableP; 
    public GameObject noodleP; 
    public GameObject etcP;
    public GameObject[] btn;

    public void MeatBtn()
    {
        meatP.SetActive(true);
        AllBtnFalse();
    }

    public void VegetabelBtn()
    {
        vegatableP.SetActive(true);
        AllBtnFalse();
    }

    public void NoodleBtn()
    {
        noodleP.SetActive(true);
        AllBtnFalse();
    }

    public void EtcBtn()
    {
        etcP.SetActive(true);
        AllBtnFalse();
    }

    public void AllBtnFalse()
    {
        for (int i = 0; i < btn.Length; i++)
        {
            btn[i].SetActive(false);
        }
    }

    public void Btn()
    {
        meatP.SetActive(false);
        vegatableP.SetActive(false);
        noodleP.SetActive(false);
        etcP.SetActive(false);

        for(int i =0; i < btn.Length; i++) 
        {
            btn[i].SetActive(true);
        }
    }
}