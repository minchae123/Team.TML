using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamBi : MonoBehaviour, IPoolable
{
    public List<string> recipe;
    public int index = 0;
    [SerializeField] int count;

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

        if (recipe.Count == 0)
        {
            Money();
        }
    }

    public void Money()
    {
        if (index > 0)
        {
            GameManager.Instance.Money += 5000 + count * 1000 - index * 1500;
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
