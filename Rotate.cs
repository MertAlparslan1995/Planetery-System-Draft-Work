using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    float timeCounter = 0;

    float speed;
    float width;
    float height;
	// Use this for initialization
	void Start () {
        speed = 1;
        width = 8;
        height = 4;
	}
	
	// Update is called once per frame
	void Update () {
        timeCounter += Time.deltaTime * speed;
        float x = Mathf.Cos(timeCounter) * width;
        float y = 3;
        float z = Mathf.Sin(timeCounter) * height; ;

        transform.position = new Vector3(x, y, z);
	}
}
