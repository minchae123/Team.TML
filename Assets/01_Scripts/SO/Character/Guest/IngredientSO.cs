using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="SO/Recipe")]
public class IngredientSO : ScriptableObject
{
    public int level;

    [Header("고기")]
    public List<string> meatList;

    [Header("채소")]
    public List<string> vegetableList;

    [Header("면")] 
    public List<string> noodleList;

    [Header("꼬치")]
    public List<string> stickList;

    [Header("기타")]
    public List<string> etcList;
}

[System.Serializable]
public class MeatList
{
    public bool sheep = false;
    public bool cow = false;
}

[System.Serializable]
public class VegetableList
{
    public bool cabbage = false;
    public bool cheongyeong = false;
    public bool pangi = false;
    public bool pyogo = false;
    public bool saesongi = false;
    public bool mogi = false;
    public bool suckju = false;
    public bool sweetPo = false;
    public bool poatao = false;
}

[System.Serializable]
public class NoodleList
{
    public bool cornMeon = false;
    public bool dang = false;
    public bool wideDang = false;
    public bool boonmoja = false;
}

[System.Serializable]
public class StickList
{
    public bool stick = false;
    public bool ball = false;
}

[System.Serializable]
public class EtcList
{
    public bool driedTofu = false;
    public bool butcher = false;
    public bool cheesecake = false;
    public bool sweetPotatoRiceCake = false;
    public bool quailEggs = false;
    public bool sausage = false;
}