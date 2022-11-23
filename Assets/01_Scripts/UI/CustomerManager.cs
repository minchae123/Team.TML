using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CustomerManager : MonoBehaviour
{
    public CustomerManager Instance = null;

    public IngredientRecipeListSO list;

    //public List<NamBi> namBii;
    public NamBi namBii;

    public AudioSource ef;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("Multiple Gamemanager is running");
        }
        Instance = this;
    }

    private void Start()
    {
        PoolingManager.CreatePool("Customer", this.transform, 1);
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
        namBii = FindObjectOfType<NamBi>();
        namBii.recipe = re;
    }
}
