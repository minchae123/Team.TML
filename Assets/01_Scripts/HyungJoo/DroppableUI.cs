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

    void Awake()
    {
        _image = GetComponent<Image>();
        rect = GetComponent<RectTransform>();
        pool = FindObjectOfType<NamBiPool>();
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
        _image.color = Color.white;
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
                        nambi.Money();
                        StartCoroutine(Success());
                    }
                }
                catch(Exception e)
                {
                    Debug.Log(e.Message);
                }
            }

            eventData.pointerDrag.transform.SetParent(transform);
            eventData.pointerDrag.GetComponent<RectTransform>().position = rect.position;
        }
    }

    IEnumerator Success()
    {
        yield return new WaitForSeconds(0.3f);

        pool.NewNamBi();
    }
}
