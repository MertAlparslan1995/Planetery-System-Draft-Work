using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUranus : MonoBehaviour
{
    float timeCounter = 0;

    float speed;
    float width;
    float height;
    // Use this for initialization
    void Start()
    {
        speed = 1;
        width = 7;
        height = 12;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;
        float x = Mathf.Cos(timeCounter) * width;
        float y = Mathf.Sin(timeCounter) * height;
        float z = 3;

        transform.position = new Vector3(x, y, z);
    }
}