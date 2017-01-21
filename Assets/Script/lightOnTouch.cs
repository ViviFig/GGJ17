using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightOnTouch : MonoBehaviour {

    public GameObject light;
    public int collisions;


    private void OnCollisionEnter(Collision collision)
        
    {
        collisions++;
        if (collision.gameObject.tag == "Plane" && collisions >1) {
            
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        GameObject tempLight = Instantiate(light, pos, rot);
        
        Destroy(tempLight, 0.1f);
            
        }
    }

}
