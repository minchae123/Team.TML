using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="SO/recipe")]
public class IngredientSO : ScriptableObject
{
    [Header("고기")]
    public List<string> meatList;

    [Header("채소")]
    public List<string> vegetableList;

    [Header("면")]
    public List<string>  noodleList;

    [Header("꼬치")]
    public List<string> stickList;

    [Header("기타")]
    public List<string> etcList;
}



