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

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("Multiple Gamemanager is running");
        }
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(ingre, po, Quaternion.identity, GameObject.Find("MainCanvas").transform);
        }
    }
}