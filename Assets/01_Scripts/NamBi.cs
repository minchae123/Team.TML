using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamBi : MonoBehaviour
{
    public List<string> recipe;
    int index = 0;

    public void AddItem(string ingre)
    {
        if (!recipe.Contains(ingre))
        {
            index++;
            return;
        }

        recipe.Remove(ingre);
        if(recipe.Count == 0)
        {
            Debug.Log("¿Ï¼­¾î¾û");
        }
    }
}
