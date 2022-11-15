using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Recipe : MonoBehaviour
{
    //public Text showTxt;
    public TextMeshProUGUI txt;

    public IngredientRecipeListSO listSO;
    public IngredientSO ingredientSO;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SetRecipe();

        }
    }

    public void SetRecipe()
    {
        int index = Random.Range(0,listSO.ingredients.Count);

        ingredientSO = listSO.ingredients[index];
        TextShow();
    }

    public void TextShow()
    {
        txt.text = string.Empty;

        SetIngredient(ingredientSO.meatList);
        SetIngredient(ingredientSO.vegetableList);
        SetIngredient(ingredientSO.noodleList);
        SetIngredient(ingredientSO.stickList);
        SetIngredient(ingredientSO.etcList);
    }

    void SetIngredient(List<string> ingredients)
    {
        foreach (string ingredient in ingredients)
        {
            txt.text += $"{ingredient} ";
        }
        txt.text += "\n";
    }
}
