using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="SO/recipe")]
public class IngredientSO : ScriptableObject
{
    [Header("���")]
    public List<string> meatList;

    [Header("ä��")]
    public List<string> vegetableList;

    [Header("��")]
    public List<string>  noodleList;

    [Header("��ġ")]
    public List<string> stickList;

    [Header("��Ÿ")]
    public List<string> etcList;
}



