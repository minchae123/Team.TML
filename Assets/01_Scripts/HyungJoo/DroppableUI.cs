using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DroppableUI : MonoBehaviour,IPointerEnterHandler,IDropHandler,IPointerExitHandler
{
    public bool gas;
    public bool clear;
    public bool namBi;

    private Image _image;
    RectTransform rect;

    Color co;

    void Awake()
    {
        _image = GetComponent<Image>();
        rect = GetComponent<RectTransform>();
        co = this._image.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(!gas && !clear)
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
            if (gas == true || clear == true)
            {
                if (eventData.pointerDrag.gameObject.GetComponent<DraggableUI>().nambi == false)
                {
                    return;
                }
            }

            NamBi nambi = transform.GetComponent<NamBi>();

            if (nambi != null)
            {
                Yummy yummy = eventData.pointerDrag.gameObject.GetComponent<Yummy>();
                if (yummy != null)
                {
                    nambi.AddItem(yummy.ingredientName);
                }
            }

            if(clear == true && transform.childCount > 0)
            {
                Debug.Log("¿Ï·á");
                nambi.Money();
            }

            eventData.pointerDrag.transform.SetParent(transform);
            eventData.pointerDrag.GetComponent<RectTransform>().position = rect.position;
        }
    }
}
