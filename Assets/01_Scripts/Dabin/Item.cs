using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Equiment,
    Consumables,
    Etc
}

[System.Serializable]
public class Item 
{
    public ItemType itemType;
    public string ItemName;
    public Sprite itemImage;

    public bool Use()
    {
        return false;
    }
}
