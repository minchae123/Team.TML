using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Meat
{
    양고기, 소고기
}

public enum Vegetable
{
    배추, 청경채, 팽이버섯, 표고버섯, 새송이버섯, 목이버섯, 숙주, 고구마, 감자
}

public enum Noodle
{
    옥수수면, 당면, 넓적당면, 분모자당면
}

public enum Etc
{
    꼬치, 완자, 건두부, 푸주, 치즈떡, 고구마떡, 메추리알, 소세지
}

[CreateAssetMenu(menuName ="SO/Recipe")]
public class IngredientSO : ScriptableObject
{
    public int level;
    public Sprite sp;

    [Header("고기")]
    public List<Meat> meatList;

    [Header("채소")]
    public List<Vegetable> vegetableList;

    [Header("면")] 
    public List<Noodle> noodleList;

    [Header("기타")]
    public List<Etc> etcList;
}
