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
<<<<<<< Updated upstream
=======

    Color co;

    private NamBiPool pool;

>>>>>>> Stashed changes
    void Awake()
    {
        _image = GetComponent<Image>();
        rect = GetComponent<RectTransform>();
<<<<<<< Updated upstream
=======
        pool = FindObjectOfType<NamBiPool>();
        co = this._image.color;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            if (gas == true || clear == true)
            {
                if (eventData.pointerDrag.gameObject.GetComponent<DraggableUI>().nambi == false)
                {
                    return;
                }
            }
            NamBi nambi = transform.GetComponent<NamBi>();
=======
            NamBi nambi = FindObjectOfType<NamBi>();

>>>>>>> Stashed changes
            if (nambi != null)
            {
                Yummy yummy = eventData.pointerDrag.gameObject.GetComponent<Yummy>();
                if (yummy != null)
                {
                    nambi.AddItem(yummy.ingredientName);
                }
            }
<<<<<<< Updated upstream
=======

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

>>>>>>> Stashed changes
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
