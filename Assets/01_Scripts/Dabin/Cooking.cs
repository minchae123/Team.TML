using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Cooking : MonoBehaviour
{
    [Tooltip("끓는 시간")] public int boilTime;
    [Tooltip("타는 시간")] public int burnTime = 1;

    public float time;

    public bool start;
    public bool end;
    public GameObject bBogle;

    public NamBi bi;
    public Sprite[] inm;
    public Image curImage;

    public DraggableUI ui;

    public void Start()
    {
        bi = GetComponent<NamBi>();
        curImage = GetComponent<Image>();
        ui = GetComponent<DraggableUI>();
        burnTime = 1;
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
        ui.enabled = false;
        GameObject.Find("Manager").transform.Find("Booggle").gameObject.SetActive(true);
        yield return new WaitForSeconds(CheckTime());
        bBogle = GameObject.Find("Booggle");
        bBogle.GetComponent<ParticleSystem>().Play();

        curImage.sprite = inm[0];

        yield return new WaitForSeconds(CheckTime());

        for(int i =0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

        yield return new WaitForSeconds(CheckTime());
        bBogle.GetComponent<ParticleSystem>().Stop();
        ui.enabled = true;
        curImage.sprite = inm[1];
        end = true;
    }

    public float CheckTime()
    {
        switch (burnTime)
        {
            case 1 :
                time = 3.5f;
                break;
            case 2 :
                time = 2.5f;
                break;
            case 3 :
                time = 1f;
                break;
        }
        return time;
    }
}
