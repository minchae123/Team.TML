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
    public Sprite ingredientImage; // ���⿡�ٰ� ��� �̹��� �߰�
    public int ingredientNumber; // �������� ���� �춧���� ����

    public bool Use()
    {
        return false;
    }
}
