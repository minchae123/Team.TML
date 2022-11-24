using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cooking : MonoBehaviour
{
    [Tooltip("끓는 시간")] public int boilTime;
    [Tooltip("타는 시간")] public int burnTime;

    public bool start;

    Renderer rend;
    Color currentColor;

    public GameObject bBogle;

    public NamBi bi;

    public void Start()
    {
        rend = GetComponent<Renderer>();
        currentColor = Color.white;
        bi = GetComponent<NamBi>();
        //bBogle = GameObject.Find("Booggle");
    }

    private void Update()
    {
        if (bi.isCook)
        {
            Debug.Log("시작");
            bi.isCook = false;
            StartCoroutine(StartCook());
        }
    }

    public void Boiling()
    {
        rend.material.DOColor(Color.black, burnTime);
    }

    IEnumerator StartCook()
    {
        GameObject.Find("Manager").transform.FindChild("Booggle").gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        bBogle = GameObject.Find("Booggle");
        bBogle.GetComponent<ParticleSystem>().Play();

        bBogle.GetComponent<ParticleSystem>().Play();


    }
}
