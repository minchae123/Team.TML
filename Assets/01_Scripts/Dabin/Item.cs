using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum IngredientType
{
    Meat,
    Vegetable,
    Noodle,
    Etc
}

[System.Serializable]
public class Item 
{
    public IngredientType ingredientType; 
    public string ingredientName; // 
    public Sprite ingredientImage; // 여기에다가 재료 이미지 추가
    public int ingredientNumber; // 상점에서 음식 살때마다 증가

    public bool Use()
    {
        return false;
    }
}
