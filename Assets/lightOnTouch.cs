using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightOnTouch : MonoBehaviour {

    public GameObject light;

	void Start () {
	}
	
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        GameObject tempLight = Instantiate(light, pos, rot);
        light = tempLight;
        Destroy(tempLight, 4);
    }
}
