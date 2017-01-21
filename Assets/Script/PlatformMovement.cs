using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {
    bool up;
    bool down;
    private void Start()
    {
        up = true;
    }
    void UpAndDownMovement()
    {

        if (up) {
            
            transform.Translate(Vector3.up * Time.deltaTime);
            
        }

       else if (down) {
           
            transform.Translate(Vector3.down * Time.deltaTime);
            
        }
            
    }




    private void Update()
    {
        UpAndDownMovement();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Up")
        {
            up = false;
            down = true;
        }
            
       else if (other.tag == "Down")
        {
            down = false;
            up = true;
        }
            
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Up")
        {
            up = false;
            down = true;
        }
            
        else if (other.tag == "Down")
        {
            down = false;
            up = true;
        }
            
    }
}
