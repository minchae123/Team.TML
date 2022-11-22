using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamBiPool : MonoBehaviour
{
    public string NAME { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    private void Start()
    {
        PoolingManager.CreatePool("NamBi", this.transform, 1);
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
