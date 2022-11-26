using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamBi : MonoBehaviour, IPoolable
{
    public List<string> recipe;
    int index = 0;
    public int count = 0;
    public int upLevel = 1000;

    private string objName;
    public string NAME { get => objName; set => objName = value; }

    public AudioSource ef;

    public bool isCook;
    public bool iss;

    public void AddItem(string ingre)
    {
        if (!iss) isCook = true;

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
            GameManager.Instance.Money += 5000 + count * upLevel - index * 1500;
            GameManager.Instance.TOMoney += 5000 + count * upLevel - index * 1500;
        }
        else
        {
            GameManager.Instance.Money += 5000 + (upLevel * 1);
            GameManager.Instance.TOMoney += 5000 + (upLevel * 1);
        }
        
        ef = FindObjectOfType<AudioSource>();
        ef.Play();
    }

    public void OnPool()
    {

    }

    public void PushObj() => PoolingManager.PushObject(NAME, this.gameObject);

}
