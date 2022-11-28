using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreXButtonClick : MonoBehaviour
{
    public GameObject storeCanvas;

    public void StoreXButton()
    {
        GameManager.Instance.StartDay();
        storeCanvas.SetActive(false);

    }
}
