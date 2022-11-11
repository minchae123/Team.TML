using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feed : MonoBehaviour
{
    public GameObject food;
    public Vector3 mousePos;
    public float speed;
    float delay = 0.5f;

    IEnumerator ThrowFood(){
        while(true){
            if(Input.GetKey(KeyCode.Mouse0)){
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);            }
            yield return new WaitForSeconds(delay);
        }
    }
}
