using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="SO/ListSO")]
public class IngredientRecipeListSO : ScriptableObject
{
    public List<IngredientSO> ingredients = new List<IngredientSO>();


}
