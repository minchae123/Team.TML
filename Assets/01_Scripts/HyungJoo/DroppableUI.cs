using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DroppableUI : MonoBehaviour,IPointerEnterHandler,IDropHandler,IPointerExitHandler
{
    public bool clear;
    public bool ch;

    private Image _image;
    RectTransform rect;
    Color co;

    private NamBiPool pool;
    private CustomerManager customerManager;

    public GameObject del;

    void Awake()
    {
        _image = GetComponent<Image>();
        rect = GetComponent<RectTransform>();
        pool = FindObjectOfType<NamBiPool>();
        customerManager = FindObjectOfType<CustomerManager>();
        co = this._image.color;

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(!clear)
        {
            _image.color = Color.yellow;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _image.color = co;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            NamBi nambi = FindObjectOfType<NamBi>();

            if (nambi != null)
            {
                Yummy yummy = eventData.pointerDrag.gameObject.GetComponent<Yummy>();
                if (yummy != null)
                {
                    nambi.AddItem(yummy.ingredientName);
                }
            }

            if (clear == true)
            {
                if (eventData.pointerDrag.gameObject.GetComponent<DraggableUI>().nambi == false)
                {
                    return;
                }
                try
                {
                    if(nambi != null)
                    {
                        GameObject nam = GameObject.Find("NamBi(Clone)");
                        nam.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
                        nambi.Money();
                        del = GameObject.Find("Customer(Clone)");
                        StartCoroutine(Success());
                    }
                }
                catch(Exception e)
                {
                    Debug.LogException(e);
                }
            }
            eventData.pointerDrag.transform.SetParent(transform);
            eventData.pointerDrag.GetComponent<RectTransform>().position = rect.position;
        }
    }

    public IEnumerator Success()
    {
        yield return new WaitForSeconds(2f);
        Recipe re = FindObjectOfType<Recipe>();
        re.ThanksTxt();
        yield return new WaitForSeconds(2f);
        pool.NewNamBi();
        customerManager.ShowCustomer();
        Destroy(del);
        yield return new WaitForSeconds(2f);
    }
}
