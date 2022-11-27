using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientManager : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public Slot[] slots;
    public List<string> names = new List<string>();
    [Tooltip("slot하나에 들어갈 수 있는 최대 수")] public int maxNum = 100;

    int I = 0;

    private void Start()
    {
       /* for(int i = 0; i < items.Count; i++)
        {
            Debug.Log($"{i}번째 : {items[i].ingredientName}");
        }*/
    }

    public bool CheckIndex(int num)
    {
        if (names.Contains(items[num].ingredientName))
        {
            return true;
        }
        else
        {
            if(names.Count != 0)
            {
                I++;
            }
            names.Add(items[num].ingredientName);
        }
        return false;
    }

    public bool NotPullSlot(int i)
    {
        if (items[i].ingredientNumber > maxNum)
        {
            items[i].ingredientNumber = 0;
            I++;
            return false;
        }
        return true;
    }

    public void IngredientSubstitution(int i)
    {
        if (CheckIndex(i) && NotPullSlot(i))
        {
            if(slots[I]._ingredientImage.enabled == false)
            {
                slots[I]._ingredientImage.enabled = true;
                slots[I].text.text = $"{items[i].ingredientName} : {items[i].ingredientNumber}";
                slots[I]._ingredientImage.sprite = items[i].ingredientImage;
            }
            else
            {
                slots[I].text.text = $"{items[i].ingredientName} : {items[i].ingredientNumber}";
            }
        }
    }
}
