using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamBi : MonoBehaviour, IPoolable
{
    public List<string> recipe;
    int index = 0;
    public int count;

    private string objName;
    public string NAME { get => objName; set => objName = value; }

    public void AddItem(string ingre)
    {
        if (!recipe.Contains(ingre))
        {
            index++;
            return;
        }

        recipe.Remove(ingre);
        count++;
        if(recipe.Count == 0)
        {
            Debug.Log("¿Ï¼­¾î¾û");
        }
    }

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

}
