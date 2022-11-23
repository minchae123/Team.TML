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
<<<<<<< Updated upstream
=======

    public void Money()
    {
        if (index > 0)
        {
            GameManager.Instance.Money += 5000 + count * 1000 - index * 1500;
        }
        else if(count < 0)
        {
            GameManager.Instance.Money -= 5000;
        }
        else
        {
            GameManager.Instance.Money += 5000 + (count * 1000);
        }
    }

    public void OnPool()
    {
    }

    public void PushObj() => PoolingManager.PushObject(NAME, this.gameObject);
>>>>>>> Stashed changes
}
