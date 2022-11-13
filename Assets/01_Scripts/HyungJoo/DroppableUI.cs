using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DroppableUI : MonoBehaviour,IPointerEnterHandler,IDropHandler,IPointerExitHandler
{
    private Image _image;
    RectTransform rect;
    void Awake()
    {
        _image = GetComponent<Image>();
        rect = GetComponent<RectTransform>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(true)
        {
            _image.color = Color.yellow;

        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        _image.color = Color.green;
    }
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.transform.SetParent(transform);
            eventData.pointerDrag.GetComponent<RectTransform>().position = rect.position;
        }
    }
}
