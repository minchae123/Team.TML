using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestSpawner : MonoBehaviour
{
    public float comeDelay = 3f;

    public Ingredient[] ingre;
    public int index;

    public int[] meat;
    public int[] vegetable;
    public int[] noodle;
    public int[] etc;

    public List<int> ingredient;
    
    private void Awake()
    {
        index = Random.Range(0, ingre.Length);
        meat = new int[] { ingre[index].i.cowMeat, ingre[index].i.sheepMeat};
        vegetable = new int[] { ingre[index].i.cabbage, ingre[index].i.pakChoi, ingre[index].i.blackMushroom, ingre[index].i.pangiMushroom, ingre[index].i.pangiMushroom, 
            ingre[index].i.pyogoMushroom, ingre[index].i.sasongiMushroom, ingre[index].i.mungSporout, ingre[index].i.sweetPotato, ingre[index].i.potato};
        noodle = new int[] { ingre[index].i.cornMeon, ingre[index].i.oriDang, ingre[index].i.wideDang, ingre[index].i.boonMoJa };
        etc = new int[] { ingre[index].i.dryTofu, ingre[index].i.puju, ingre[index].i.cheezeTt, ingre[index].i.sweetTt, ingre[index].i.quailEgg, ingre[index].i.sausage };
    }

    private void Start()
    {
        StartCoroutine(GetRecipe());
    }

    IEnumerator GetRecipe()
    {
        AddRecipe(meat);
        AddRecipe(vegetable);
        AddRecipe(noodle);
        AddRecipe(etc);
        yield return new WaitForSeconds(0.2f);
    }

    public void AddRecipe(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > 0)
            {
                ingredient.Add(a[i]);
            }
        }
    }
}
