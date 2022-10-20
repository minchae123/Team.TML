using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestSpawner : MonoBehaviour
{
    public Ingredient[] n = new Ingredient();
    public float comeDelay = 3f;

    public List<int> meat = new List<int>();

    private void Start()
    {
        meat.Add(n.i.sheepMeat);
    }

    IEnumerator GetRecipe()
    {
        int r = Random.Range(0, n.Length);
        for(int i = 0;i < 39; i++)
        {

        }
        yield return new WaitForSeconds(comeDelay);
    }
}
