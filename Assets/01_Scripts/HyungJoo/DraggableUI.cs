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
            _droppableUI ??= GameObject.Find("DroppableUI");
            return _droppableUI;
        }
    }
    private Transform _canvas;
    public Vector3 originPos;
    RectTransform rect;
    public bool dragged;
    private GameObject _droppableUI;
    private CanvasGroup _canvasGroup;
    private void Awake()
    {
        rect = GetComponent<RectTransform>();
        _canvas = GameObject.Find("Canvas").transform;
        _canvasGroup = GetComponent<CanvasGroup>();
    }
    //drag ����������
    public void OnBeginDrag(PointerEventData eventData)
    {
        originPos = transform.position;
        transform.SetParent(_canvas);
        transform.SetAsFirstSibling();

        _canvasGroup.alpha =0.5f;
        _canvasGroup.blocksRaycasts = false;
        transform.position = eventData.position;

    }


    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }


}