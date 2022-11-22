using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreGoods : MonoBehaviour
{
    public Text[] text;
    public Image[] image;

    IngredientManager ingredientManager;

    public void MeatSubstitution()
    {
        for (int i = 0; i < ingredientManager.items.Count; i++)
        {
            if (ingredientManager.items[i].ingredientType == IngredientType.Meat)
            {
                text[i].text = $"{ingredientManager.items[i].ingredientName} : {ingredientManager.items[i].ingredientNumber}";
                image[i].sprite = ingredientManager.items[i].ingredientImage;
            }
        }
    }
    
    public void VegetableSubstitution()
    {
        for (int i = 0; i < ingredientManager.items.Count; i++)
        {
            if (ingredientManager.items[i].ingredientType == IngredientType.Vegetable)
            {
                text[i].text = $"{ingredientManager.items[i].ingredientName} : {ingredientManager.items[i].ingredientNumber}";
                image[i].sprite = ingredientManager.items[i].ingredientImage;
            }
        }
    }
    
    public void NoodleSubstitution()
    {
        for (int i = 0; i < ingredientManager.items.Count; i++)
        {
            if (ingredientManager.items[i].ingredientType == IngredientType.Noodle)
            {
                text[i].text = $"{ingredientManager.items[i].ingredientName} : {ingredientManager.items[i].ingredientNumber}";
                image[i].sprite = ingredientManager.items[i].ingredientImage;
            }
        }
    }
    
    public void EtcSubstitution()
    {
        for (int i = 0; i < ingredientManager.items.Count; i++)
        {
            if (ingredientManager.items[i].ingredientType == IngredientType.Etc)
            {
                text[i].text = $"{ingredientManager.items[i].ingredientName} : {ingredientManager.items[i].ingredientNumber}";
                image[i].sprite = ingredientManager.items[i].ingredientImage;
            }
        }
    }
}
