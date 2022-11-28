using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientManager : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public List<string> names = new List<string>();
    public Slot[] slots;
    [Tooltip("slot하나에 들어갈 수 있는 최대 수")] public int maxNum = 100;
    
    public GameObject storePanel;
    public Vector2 domaMin;
    public Vector2 domaMax;
    public GameObject[] dragObject;

    public Vector3 dir;
    private int I = 0;
    bool isBuyying = false;

    private void Start()
    {
        isBuyying = false;
    }

    public void StoreBtn()
    {
        storePanel.SetActive(!storePanel.activeSelf);
    }

    public void IngredientDrop(int i)
    {
        if (isBuyying)
        {
            dir.x = Random.Range(domaMin.x, domaMax.x);
            dir.y = Random.Range(domaMin.y, domaMax.y);
            Instantiate(dragObject[ReturnInt(i)], dir, Quaternion.identity, GameObject.Find("Doma").transform);
        }
    }

    public bool CheckIndex(int i)
    {
        if (names.Contains(items[i].ingredientName))
        {
            return true;
        }
        else
        {
            if(names.Count != 0)
            {
                I++;
            }
            names.Add(items[i].ingredientName); 
            slots[I]._ingredientImage.enabled = true;
            slots[I].text.text = $"{items[i].ingredientName} : {items[i].ingredientNumber}";
            slots[I]._ingredientImage.sprite = items[i].ingredientImage;
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
        isBuyying = true;
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
                Debug.Log("여기인가?");
                slots[ReturnInt(i)].text.text = $"{items[i].ingredientName} : {items[i].ingredientNumber}";
            }
        }
    }

    public int ReturnInt(int _i)
    {
        for(int i = 0; i < names.Count; i++)
        {
            if(names[i] == items[_i].ingredientName)
            {
                return i;
            }
        }
        return 0;
    }
}
