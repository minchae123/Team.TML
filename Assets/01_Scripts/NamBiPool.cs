using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamBiPool : MonoBehaviour
{
    public static NamBiPool Instance = null;

    private void Awake()
    {
        if(Instance != null)
        {
            Debug.Log(null);
        }
        Instance = this;
        PoolingManager.CreatePool("NamBi", this.transform, 1);
    }

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            NewNamBi();
        }
    }

    public void NewNamBi()
    {
        GameObject obj = PoolingManager.PopObject("NamBi");
    }
}
