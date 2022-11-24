using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cooking : MonoBehaviour
{
    [Tooltip("���� �ð�")] public int boilTime;
    [Tooltip("Ÿ�� �ð�")] public int burnTime;

    public bool start;

    Renderer rend;
    Color currentColor;

    public GameObject bBogle;

    public void Start()
    {
        rend = GetComponent<Renderer>();
        currentColor = Color.white;
        //bBogle = GameObject.Find("Booggle");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            StartCoroutine(StartCook());
        }
    }

    public void Boiling()
    {
        rend.material.DOColor(Color.black, burnTime);
    }

    IEnumerator StartCook()
    {
        yield return new WaitForSeconds(1f);
        bBogle.SetActive(true);
        bBogle.GetComponent<ParticleSystem>().Play();


    }
}
