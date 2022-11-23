using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamBi : MonoBehaviour, IPoolable
{
    public List<string> recipe;
    int index = 0;
    public int count = 0;

    private string objName;
    public string NAME { get => objName; set => objName = value; }

    public AudioSource ef;

    public void AddItem(string ingre)
    {
        if (!recipe.Contains(ingre))
        {
            index++;
            return;
        }

        recipe.Remove(ingre);
        count++;
    }

    public void Money()
    {
        if (index > 0)
        {
            GameManager.Instance.Money += 5000 + count * 1000 - index * 1500;
        }
        else if(count == 0)
        {
            GameManager.Instance.Money -= 5000;
        }
        else
        {
            GameManager.Instance.Money += 5000 + (count * 1000);
        }
        
        ef = FindObjectOfType<AudioSource>();

        ef.Play();
    }

    public void OnPool()
    {

    }

    public void PushObj() => PoolingManager.PushObject(NAME, this.gameObject);

}
