using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoreMoney : MonoBehaviour
{
    public TextMeshProUGUI mo;

    private void Update()
    {
        mo.text = string.Format("�� : {0:#,###} ��", GameManager.Instance.Money);
    }
}
