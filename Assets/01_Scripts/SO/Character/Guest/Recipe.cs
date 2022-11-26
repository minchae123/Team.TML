using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Recipe : MonoBehaviour, IPoolable
{
    public TextMeshProUGUI txt;

    public List<string> save;

    public CustomerManager customer;

    public Slider slider;

    public GameObject btn;

    private IngredientSO ingredientSO;
    public IngredientSO IngredientSO
    {
        get => ingredientSO; 
        set
        {
            ingredientSO = value;
            SetRecipe();
        }

    }

    private string objName;
    public string NAME { get => objName; set => objName = value; }

    private void Awake()
    {
        customer = FindObjectOfType<CustomerManager>();
        slider = FindObjectOfType<Slider>();
    }

    private void Update()
    {
    }

    public void SetRecipe()
    {
        GetComponent<Image>().sprite = ingredientSO.sp;
        TextShow();
    }

    public void TextShow()
    {
        txt.text = string.Empty;

        SetIngredient(ingredientSO.meatList);
        SetIngredient(ingredientSO.vegetableList);
        SetIngredient(ingredientSO.noodleList);
        SetIngredient(ingredientSO.etcList);

        txt.text += ingredientSO.tell;
        customer.SetRecipe(save);
    }

    public void ThanksTxt()
    {
        txt.text = ingredientSO.thanks;
    }

    void SetIngredient<T>(List<T> ingredients)
    {
        foreach (T ingredient in ingredients)
        {
            save.Add(ingredient.ToString());
        }
    }

    public void GetOrder()
    {
        Destroy(btn);
        GameObject.Find("Ingredient").transform.GetComponentInChildren<DraggableUI>().isMove = true;
        GameObject.Find("NamBi(Clone)").GetComponent<DroppableUI>().isGo = true;
        Debug.Log("주문");
        StartCoroutine(Order());
    }

    IEnumerator Order()
    {
        while (slider.value >= 0)
        {
            slider.value -= Time.deltaTime;
            yield return null;
        }
    }

    public void OnPool()
    {
    }

    public void PushObj() => PoolingManager.PushObject(NAME, this.gameObject);
    
    /*public void PushObj() 이 코드를 람다로
    {
         PoolingManager.PushObject(NAME, this.gameObject);
    }*/
}
