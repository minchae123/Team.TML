using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooking : MonoBehaviour
{
    [Tooltip("²ú´Â ½Ã°£")] public int boilTime;
    [Tooltip("Å¸´Â ½Ã°£")] public int burnTime;

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
        Debug.Log("²ú´ÂÁß");
        yield return new WaitForSeconds(boilTime);
        Debug.Log("´Ù²úÀ½");
        yield return new WaitForSeconds(burnTime - boilTime);
        Debug.Log("Å¸¹ö·ÈÀ½");
    }
}
