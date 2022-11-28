using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoreMoney : MonoBehaviour
{
    public TextMeshProUGUI mo;

    private void Update()
    {
        mo.text = string.Format("µ· : {0:#,###} ¿ø", GameManager.Instance.Money);
    }
}
