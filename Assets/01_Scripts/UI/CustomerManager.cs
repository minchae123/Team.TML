using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CustomerManager : MonoBehaviour
{
    public IngredientRecipeListSO list;

    public List<NamBi> namBii;

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

    public void SetRecipe(List<string> re)
    {
        for (int i = 0; i < namBii.Count; i++)
        {
            namBii[i].recipe = re;
        }
    }
}
