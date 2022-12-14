using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Cooking : MonoBehaviour
{   
    public static Cooking Instance = null;

    private void Awake() {
        
        if (Instance == null)
        {
            Instance = this;
        }     
    }
    [Tooltip("Ÿ�� �ð�")] public int burnTime = 1;

    public float time;

    public bool start;
    public bool end;
    public GameObject bBogle;

    public NamBi bi;
    public Sprite[] inm;
    public Image curImage;

    public DraggableUI ui;
    public DroppableUI uii;

    public AudioSource boo;

    public void Start()
    {
        bi = GetComponent<NamBi>();
        curImage = GetComponent<Image>();
        ui = GetComponent<DraggableUI>();
        uii = GetComponent<DroppableUI>();
        burnTime = 1;

        ui.enabled = false;
        uii.enabled = false;
    }

    private void Update()
    {
        /*if (bi.isCook)
        {
            bi.iss = true;
            bi.isCook = false;
            StartCoroutine(StartCook());
        }*/
    }

    public void GoBtn()
    {
        StartCoroutine(StartCook());
    }

    IEnumerator StartCook()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
        GameObject.Find("Manager").transform.Find("Booggle").gameObject.SetActive(true);
        bBogle = GameObject.Find("Booggle");
        bBogle.GetComponent<ParticleSystem>().Play();
        curImage.sprite = inm[0];
        yield return new WaitForSeconds(CheckTime());
        curImage.sprite = inm[1];
        yield return new WaitForSeconds(1);
        uii.enabled = false;
        yield return new WaitForSeconds(CheckTime() - 1);
        curImage.sprite = inm[2];
        yield return new WaitForSeconds(CheckTime());
        boo.Stop();
        bBogle.GetComponent<ParticleSystem>().Stop();
        curImage.sprite = inm[3];
        ui.enabled = true;
        end = true;
        bi.iss = false;
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
