using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public DicIngredient dictionary;

    float delay = 3f;
    public GameObject[] inList;

    public Text txt;

    private void Awake()
    {
        StartCoroutine(Get());
    }

    IEnumerator Get()
    {
        int r = Random.Range(0, inList.Length);
        dictionary = inList[r].GetComponent<DicIngredient>();

        dictionary.GetList();
        dictionary.SetName();
        

        foreach(var se in dictionary.sets)
        {
            //Debug.Log(se.Key);

            foreach(var see in dictionary.names)
            {
                if($"{se.Key}" == $"{see.Key}")
                {
                    txt.text += $"{see.Value}\n";
                    Debug.Log(see.Value);
                }
            }

        }
        
        yield return new WaitForSeconds(delay);
    }
}
