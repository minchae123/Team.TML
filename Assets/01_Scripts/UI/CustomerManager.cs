using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    public IngredientRecipeListSO list;

    private void Start()
    {
        PoolingManager.CreatePool("Customer", this.transform);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            int index = Random.Range(0, list.ingredients.Count);

            GameObject obj = PoolingManager.PopObject("Customer");
            obj.GetComponent<Recipe>().IngredientSO = list.ingredients[index];
        }
    }
}
