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
    public bool nambi;
    private Transform _canvas;
    private Transform _previousParent;
    public Vector3 originPos;
    RectTransform rect;
    public bool dragged;
    private GameObject _droppableUI;
    private CanvasGroup _canvasGroup;

    private void Awake()
    {
        rect = GetComponent<RectTransform>();
       // _canvas = GameObject.Find("Canvas").transform;
        _canvasGroup = GetComponent<CanvasGroup>();
        _canvas = FindObjectOfType<Canvas>().transform;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originPos = transform.position;
        _previousParent = transform.parent;
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
        if (transform.parent == _canvas)
        {
            transform.SetParent(_previousParent);
            rect.position = originPos;
            transform.position = originPos;
        }
        else
        {
            this.gameObject.GetComponent<DraggableUI>().enabled = false;
        }

        _canvasGroup.alpha = 1.0f;
        _canvasGroup.blocksRaycasts = true;
    }
}
