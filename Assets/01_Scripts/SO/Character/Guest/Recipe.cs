using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Recipe : MonoBehaviour, IPoolable
{

    public void OnPool()
    {

    }

    public void PushObj() => PoolingManager.PushObject(NAME, this.gameObject);

    /*public void PushObj() 이 코드를 람다로
    {
       PoolingManager.PushObject(NAME, this.gameObject);
    }*/

    public TextMeshProUGUI txt;

    private IngredientSO ingredientSO;
    public IngredientSO IngredientSO
    {
        get => ingredientSO; 
        set
        {
            ingredientSO = value;
            SetRecipe();
        }

    }

    private string objName;
    public string NAME { get => objName; set => objName = value; }

    public void SetRecipe()
    {
        GetComponent<Image>().sprite = ingredientSO.sp;
        TextShow();
    }

    public void TextShow()
    {
        txt.text = string.Empty;

        SetIngredient(ingredientSO.meatList);
        SetIngredient(ingredientSO.vegetableList);
        SetIngredient(ingredientSO.noodleList);
        SetIngredient(ingredientSO.etcList);
    }

    void SetIngredient<T>(List<T> ingredients)
    {
        foreach (T ingredient in ingredients)
        {
            txt.text += $"{ingredient.ToString()} ";
        }
        txt.text += "\n";
    }

}
