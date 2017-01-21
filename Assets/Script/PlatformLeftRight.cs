using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformLeftRight : MonoBehaviour {

    bool left;
    bool right;
    private void Start()
    {
        left = true;
    }
    void UpAndDownMovement()
    {

        if (left)
        {

            transform.Translate(Vector3.left * Time.deltaTime);

        }

        else if (right)
        {

            transform.Translate(Vector3.right * Time.deltaTime);

        }

    }




    private void Update()
    {
        UpAndDownMovement();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Left")
        {
            left = false;
            right = true;
        }

        else if (other.tag == "Right")
        {
            right = false;
            left = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Left")
        {
            left = false;
            right = true;
        }

        else if (other.tag == "Right")
        {
            right = false;
            left = true;
        }

    }
}


