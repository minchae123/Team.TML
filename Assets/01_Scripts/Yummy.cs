using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class Yummy : MonoBehaviour, IPointerClickHandler
{
    public string ingredientName;

    public Sprite sp;

    public TextMeshProUGUI txt;

    public void OnPointerClick(PointerEventData eventData)
    {
        StartCoroutine(ShowExpain());
    }

    IEnumerator ShowExpain()
    {
        txt.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        txt.gameObject.SetActive(false);
    }
}
