using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CustomerManager : MonoBehaviour
{
    public IngredientRecipeListSO list;

    public List<NamBi> namBii;

    public AudioSource ef;

    private void Start()
    {
        PoolingManager.CreatePool("Customer", this.transform);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ShowCustomer();
        }
    }

    public void ShowCustomer()
    {
        int index = Random.Range(0, list.ingredients.Count);

        Vector3 pos = new Vector3(-81, 131, 0);

        GameObject obj = PoolingManager.PopObject("Customer");
        obj.GetComponent<Recipe>().IngredientSO = list.ingredients[index];

        ef.Play();
        obj.transform.DOLocalMove(pos, 0.8f).SetEase(Ease.Linear);
    }

    public void SetRecipe(List<string> re)
    {
        for (int i = 0; i < namBii.Count; i++)
        {
            namBii[i].recipe = re;
        }
    }
}
