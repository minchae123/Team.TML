using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inverntory : MonoBehaviour
{
    Inventory inven;

    public GameObject _inventory;
    public GameObject inventoryButton;

    public Slot[] slots;
    public Transform slotHolder;

    private void Start()
    {
        inven = Inventory.instance;
        slots = slotHolder.GetComponentsInChildren<Slot>();
        inven.onSlotCountChange += SlotChange;
        _inventory.SetActive(false);
        inventoryButton.SetActive(true);
    }

    private void SlotChange(int vall)
    {
        for(int i = 0; i < slots.Length; i++)
        {
            if(i < inven.SlotCnt)
            {
                slots[i].GetComponent<Button>().interactable = true;
            }
            else
            {
                slots[i].GetComponent<Button>().interactable = false;
            }
        }
    }

    public void ClickInventory()
    {
        _inventory.SetActive(!_inventory.activeSelf);
        inventoryButton.SetActive(!inventoryButton.activeSelf);
    }

    public void AddSlot()
    {
        IngredientManager.maxNum += 70;
    }
}
