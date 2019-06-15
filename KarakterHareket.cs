using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareket : MonoBehaviour {

    public float hiz;
    private Vector3 tus;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        tus = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        GetComponent<Rigidbody>().AddForce(tus*hiz);
    }
}
