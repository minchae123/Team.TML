using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreGoods : MonoBehaviour
{
    public int[] price;
    public Text[] ingredientPirce;

    private void Start()
    {

    }

    private void Update()
    {
        Price();
        
    }

    public void Price()
    {
        //ingredientPirce = $"АЁАн : {price}";
    }
}
