using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestSpawner : MonoBehaviour
{
    public GuestRecipeSO[] recipeSO;
    public RecipeSO[] reSO;

    IEnumerator GetRecipe()
    {
        int r = Random.Range(0, reSO.Length);
        for(int i =0;i < 39; i++)
        {

        }
        yield return new WaitForSeconds(0.2f);
    }
}
