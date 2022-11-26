using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    [SerializeField] private int money;
    public int Money { get => money; set => money = value; }

    [SerializeField] private int day = 1;
    public int Day { get => day; set => day = value; }

    private int time = 8;
    public int Time { get => time; set => time = value; }

    public GameObject ingre;
    public Vector2 po;

    private MainUIManager uiManager;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("Multiple Gamemanager is running");
        }
        Instance = this;

        uiManager = FindObjectOfType<MainUIManager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject a = GameObject.Find("Ingredient");
            Destroy(a);
            Instantiate(ingre, po, Quaternion.identity, GameObject.Find("MainCanvas").transform);
        }
    }

    public void Clear()
    {
        GameObject b = GameObject.Find("Booggle");
        if(b != null)
        {
            b.GetComponent<ParticleSystem>().Stop();
        }
        GameObject c = GameObject.Find("Customer(Clone)");
        GameObject n = GameObject.Find("NamBi(Clone)");

        if (c != null)
        {
            Destroy(c);
        }
        if (n != null)
        {
            Destroy(n);
        }
    }

    public void StartDay()
    {
        uiManager.time = 46;
        NamBiPool.Instance.NewNamBi();
        CustomerManager.Instance.ShowCustomer();
    }
}