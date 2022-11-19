using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cooking : MonoBehaviour
{
    [Tooltip("끓는 시간")] public int boilTime;
    [Tooltip("타는 시간")] public int burnTime;

    Renderer rend;
    Color currentColor;

    public void Start()
    {
        rend = GetComponent<Renderer>();
        currentColor = Color.white;
        Boiling();
    }

    public void Boiling()
    {
        rend.material.DOColor(Color.black, burnTime);
    }
}
