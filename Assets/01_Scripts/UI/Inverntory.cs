using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inverntory : MonoBehaviour
{
    public GameObject inventory;
    public GameObject inventoryButton;

    public void ClickInventory()
    {
        inventory.SetActive(!inventory.activeSelf);
        inventoryButton.SetActive(!inventoryButton.activeSelf);
    }
}
