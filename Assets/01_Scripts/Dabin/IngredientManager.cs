using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientManager : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public Slot[] slots;
    int I = 0;

    private void Start()
    {
        for(int i = 0; i < items.Count; i++)
        {
            Debug.Log($"{i}¹øÂ° : {items[i].ingredientName}");
        }
    }

    public void IngredientSubstitution(int i)
    {
        if(slots[I]._ingredientImage.enabled == false)
        {
            slots[I]._ingredientImage.enabled = true;
            slots[I].text.text = $"{items[i].ingredientName} : {items[i].ingredientNumber}";
            slots[I]._ingredientImage.sprite = items[i].ingredientImage;
            I++;
        }
        else
        {
            slots[I].text.text = $"{items[i].ingredientName} : {items[i].ingredientNumber}";
        }
    }
}
