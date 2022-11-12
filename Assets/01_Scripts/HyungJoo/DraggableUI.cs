using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject DroppableUI
    {
        get
        {
            _droppableUI ??= GameObject.Find("DroppalbeUI");
            return _droppableUI;
        }
    }
    public Vector3 originPos;
    RectTransform rect;
    public static bool dragging;
    public bool dragged;
    private GameObject _droppableUI;
    private void Awake()
    {
        dragged = false;
        dragging = false;
        rect = GetComponent<RectTransform>();
    }
    //drag ����������
    public void OnBeginDrag(PointerEventData eventData)
    {
        originPos = transform.position;
        transform.position = eventData.position;
        dragging = true;
    }
    //drage ���϶�

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }
    //drage ������ ��

    public void OnEndDrag(PointerEventData eventData)
    {
        if (DroppableUI.GetComponent<RectTransform>().position == rect.position)
        {
            dragged = true;
        }
        else
        {
            dragged = false;
        }

        if(dragged)
        {
            transform.position = DroppableUI.GetComponent<RectTransform>().position;
        }
        else
        {
            transform.position = originPos;
        }


        dragging = false;

    }

}
