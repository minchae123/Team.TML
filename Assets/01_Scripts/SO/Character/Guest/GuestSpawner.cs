using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestSpawner : MonoBehaviour
{
    public RecipeSO[] recipeSO;
    public float comeDelay = 3f;
    Ingredient ing;

    private void Start()
    {
        ing.i.level = 1;
    }

    IEnumerator GetRecipe()
    {
        int r = Random.Range(0, recipeSO.Length);
        for(int i = 0;i < 39; i++)
        {

        }
        yield return new WaitForSeconds(comeDelay);
    }
}
