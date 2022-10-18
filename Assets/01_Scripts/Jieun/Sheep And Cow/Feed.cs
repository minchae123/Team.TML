using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feed : MonoBehaviour
{
    public GameObject food;
    public Vector3 MousePos { get; set; }
    public float speed;
    float delay = 0.5f;

    IEnumerator ThrowFood(){

        while(true){
            
            yield return new WaitForSeconds(delay);
        }
    }
}
