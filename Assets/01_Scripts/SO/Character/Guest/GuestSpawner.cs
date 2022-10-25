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
        vegetable = new int[] { ingre[index].i.cabbage, ingre[index].i.pakChoi, ingre[index].i.ntariMushroom, ingre[index].i.blackMushroom, ingre[index].i.pangiMushroom, ingre[index].i.pangiMushroom, 
            ingre[index].i.pyogoMushroom, ingre[index].i.sasongiMushroom, ingre[index].i.beanSprout, ingre[index].i.mungSporout, ingre[index].i.sweetPotato, ingre[index].i.potato, ingre[index].i.cilantro };
        noodle = new int[] { ingre[index].i.cornMeon, ingre[index].i.oriDang, ingre[index].i.wideDang, ingre[index].i.boonMoJa };
        etc = new int[] { ingre[index].i.dryTofu, ingre[index].i.puju, ingre[index].i.cheezeTt, ingre[index].i.sweetTt, ingre[index].i.sujebi, ingre[index].i.fishCake, ingre[index].i.quailEgg, ingre[index].i.sausage };
    }

    private void Start()
    {
        StartCoroutine(GetRecipe());
    }

    IEnumerator GetRecipe()
    {
        for (int i = 0; i < meat.Length; i++)
        {
            if (meat[i] > 0)
            {
                ingredient.Add(meat[i]);
            }
        }
        for(int i= 0;i< vegetable.Length; i++)
        {
            if (vegetable[i] > 0)
            {
                ingredient.Add(vegetable[i]);
            }
        }
        for(int i = 0; i < noodle.Length; i++)
        {
            if(noodle[i] > 0)
            {
                ingredient.Add(noodle[i]);
            }
        }
        for(int i= 0; i< etc.Length; i++)
        {
            if (etc[i] > 0)
            {
                ingredient.Add(etc[i]);
            }
        }
        yield return new WaitForSeconds(comeDelay);
    }
}
