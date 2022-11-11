using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recipe : MonoBehaviour
{
    public int level;
    public List<IngredientInfo> meatList;
    public List<IngredientInfo> vegetableList;
    public List<IngredientInfo> noodleList;
    public List<IngredientInfo> stickList;
    public List<IngredientInfo> etcList;

    public Text showTxt;

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
        level = Random.Range(1, 6);

        SetIngredient(meatList, ingredientSO.meatList);
        SetIngredient(vegetableList, ingredientSO.vegetableList);
        SetIngredient(noodleList, ingredientSO.noodleList);
        SetIngredient(stickList, ingredientSO.stickList);
        SetIngredient(etcList, ingredientSO.etcList);

        showTxt.text = string.Empty;
        SetText(meatList);
        SetText(vegetableList);
        SetText(noodleList);
        SetText(stickList);
        SetText(etcList, true);

    }

    public void SetText(List<IngredientInfo> a, bool isLast = false)
    {
        for (int i = 0; i < a.Count; i++)
        {
            var food = a[i];
            showTxt.text += $"{food.name}";
            if (i == a.Count - 1 && isLast)
            {
                return;
            }
            else
            {
                showTxt.text += ", ";
            }
        }
        showTxt.text += "\n";
    }

    public void SetIngredient(List<IngredientInfo> a, List<string> indexList)
    {
        int index = Random.Range(1, indexList.Count + 1);
        for (int i = 0; i < index; i++)
        {
            int indeex = Random.Range(0, indexList.Count);
            int val = 0;
            for (int j = 0; j < a.Count; j++)
            {
                if (indexList[indeex] != a[j].name)
                {
                    val++;
                }
            }
            if (val == a.Count)
            {
                IngredientInfo ing = new IngredientInfo();
                ing.name = indexList[indeex];
                ing.count = 1;
                a.Add(ing);
            }
        }
    }
}

[System.Serializable]
public class IngredientInfo
{
    public string name;
    public int count;
}