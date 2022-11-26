using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreGoods : MonoBehaviour
{
    [SerializeField, Tooltip("���� �迭!!")] int[] price;
    public Text[] ingredientPirce;

    IngredientManager ingredientManager;

    private void Start()
    {
        ingredientManager = GameObject.Find("Ingredient").GetComponent<IngredientManager>();
    }

    private void Update()
    {
        Price();
    }

    public void Price()
    {
        for(int i = 0; i < price.Length; i++)
        {
            ingredientPirce[i].text = $"���� : {price[i]}";
        }
    }

    public void Purchase(int i)
    {
        if(price[i] <= GameManager.Instance.Money)
        {
            ingredientManager.items[i].ingredientNumber++;
            ingredientManager.IngredientSubstitution(i);
            GameManager.Instance.Money -= price[i];
            Debug.Log("���� ����!!");
        }
        else
        {
            Debug.Log("�Ͱ�����!!");
        }
    }
}
