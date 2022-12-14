using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CustomerManager : MonoBehaviour
{
    public static CustomerManager Instance = null;

    public IngredientRecipeListSO list;

    public NamBi namBii;

    public AudioSource ef;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("dd");
        }
        Instance = this;

        ef = GetComponent<AudioSource>();
        PoolingManager.CreatePool("Customer", this.transform, 1);
    }

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Input.GetKey(KeyCode.RightShift))
        {
            ShowCustomer();
        }
    }

    public void ShowCustomer()
    {
        int index = Random.Range(0, list.ingredients.Count);

        Vector3 pos = new Vector3(315, 131, 0);

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
