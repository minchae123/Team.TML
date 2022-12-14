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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKey(KeyCode.RightShift))
        {
            NewNamBi();
        }
    }

    public void NewNamBi()
    {
        GameObject obj = PoolingManager.PopObject("NamBi");
    }
}
