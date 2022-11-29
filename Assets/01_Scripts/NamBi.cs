using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class NamBi : MonoBehaviour, IPoolable
{
    public string NAME { get => objName; set => objName = value; }

    public void OnPool()
    {

    }

    public void PushObj() => PoolingManager.PushObject(NAME, this.gameObject);

    public List<string> recipe;
    int index = 0;
    public int count = 0;
    public int upLevel = 1000;
    public int price = 0;   

    private string objName;

    public AudioSource ef;

    public bool isCook;
    public bool iss;

    public TextMeshProUGUI pop;
    public GameObject popp;

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
            price = 5000 + (count * upLevel) - (index * 1500);
            GameManager.Instance.Money += price;
            GameManager.Instance.TOMoney += price;
            Debug.Log(price);
        }
        else if(count < 0 )
        {
            price = -10000;
            GameManager.Instance.Money += price;
            GameManager.Instance.TOMoney += price;
            Debug.Log(price);
        }
        else
        {
            price = 5000 + (upLevel * 1);
            GameManager.Instance.Money += price;
            GameManager.Instance.TOMoney += price;
            Debug.Log(price);
        }

        ef = GetComponent<AudioSource>();
        ef.Play();
        StartCoroutine(PopTxt());
    }

    IEnumerator PopTxt()
    {
        pop = GameObject.Find("PopupMoney").GetComponent<TextMeshProUGUI>();
        popp = GameObject.Find("PopupMoney");
        pop.text = $"+ {price}";
        popp.transform.DOMove(new Vector3(-6.3f, 4.53f), 1).From();

        yield return new WaitForSeconds(1f);
        pop.text = "";
        price = 0;

    }

}
