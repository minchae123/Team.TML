using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientManager : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public Slot[] slots;

    private void Update()
    {
        IngredientSubstitution();
    }

    public void IngredientSubstitution()
    {
        for(int i = 0; i < items.Count; i++)
        {
            if (slots[i].button.interactable == true)
            {
                slots[i].text.text = $"{items[i].ingredientName} : {items[i].ingredientNumber}";
                slots[i]._ingredientImage.sprite = items[i].ingredientImage;
            }
        }
    }
}
