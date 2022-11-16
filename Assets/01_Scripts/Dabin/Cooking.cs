using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooking : MonoBehaviour
{
    [Tooltip("���� �ð�")] public int boilTime;
    [Tooltip("Ÿ�� �ð�")] public int burnTime;

    public void Start()
    {
        Boiling();
    }

    public void Boiling()
    {
        StartCoroutine(BoilTime());
    }


    IEnumerator BoilTime()
    {
        Debug.Log("������");
        yield return new WaitForSeconds(boilTime);
        Debug.Log("�ٲ���");
        yield return new WaitForSeconds(burnTime - boilTime);
        Debug.Log("Ÿ������");
    }
}
