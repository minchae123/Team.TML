using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Cooking : MonoBehaviour
{
    [Tooltip("끓는 시간")] public int boilTime;
    [Tooltip("타는 시간")] public int burnTime;

    public bool start;
    public bool end;

    Renderer rend;
    Color currentColor;

    public GameObject bBogle;

    public NamBi bi;

    public Sprite[] inm;
    public Image curImage;

    public void Start()
    {
        rend = GetComponent<Renderer>();
        currentColor = Color.white;
        bi = GetComponent<NamBi>();
        curImage = GetComponent<Image>();
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
        curImage.DOColor(Color.black, burnTime);
    }

    IEnumerator StartCook()
    {
        GameObject.Find("Manager").transform.FindChild("Booggle").gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        bBogle = GameObject.Find("Booggle");
        bBogle.GetComponent<ParticleSystem>().Play();
        Boiling();

        curImage.sprite = inm[0];

        yield return new WaitForSeconds(burnTime);
        end = true;
    }
}
