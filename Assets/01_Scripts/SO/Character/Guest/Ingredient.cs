using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : ScriptableObject
{
    [field : SerializeField] public IngredientList i = new IngredientList();
}

[System.Serializable]
public class IngredientList
{
    [Header("단계")]
    public float level; // 맵기 단계

    [Header("고기")]
    public int sheepMeat; // 양고기
    public int cowMeat; // 소고기

    [Header("채소")]
    public int cabbage; // 배추
    public int pakChoi; // 청경채
    public int pangiMushroom; // 팽이버섯
    public int pyogoMushroom; // 표고버섯
    public int sasongiMushroom; // 새송이 버섯
    public int blackMushroom; // 목이버섯
    public int mungSporout; // 숙주
    public int sweetPotato; // 고구마
    public int potato; // 감자

    [Header("면")]
    public int cornMeon; // 옥수수면
    public int oriDang; // 기본 당면
    public int wideDang; // 넓적 당면
    public int boonMoJa; // 분모자 당면

    [Header("꼬치")]
    public int ggochi; // 새우꼬치
    public int meatBall; // 완자

    [Header("기타")]
    public int dryTofu; // 건두부
    public int puju; // 푸주
    public int cheezeTt; // 치즈떡
    public int sweetTt; // 고구마떡
    public int quailEgg; // 메추리알
    public int sausage; // 소세지
}
