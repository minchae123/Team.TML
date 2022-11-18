using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraColor : MonoBehaviour
{
    Camera cam;

    public float second;
    public float speed;
    public Color[] co;

    private int index = 0;
    private int nextIndex = 1;

    private void Awake()
    {
        cam = GetComponent<Camera>();

        StartCoroutine(Cycle());
    }

    IEnumerator Cycle()
    {
        yield return new WaitForSeconds(second);

        float timer = 0f;
        float lerpTime = 0f;

        while (true)
        {
            lerpTime += Time.deltaTime * speed;

            cam.backgroundColor = Color.Lerp(co[index], co[nextIndex], lerpTime);

            if (cam.backgroundColor.Equals(co[nextIndex]))
            {
                timer += Time.deltaTime;
            }

            if (timer > second)
            {
                timer = 0f;
                lerpTime = 0f;
                index = (index + 1) % co.Length;
                nextIndex = (index + 1) % co.Length;
            }

            yield return null;
        }
    }
}
