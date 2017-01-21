using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSasso : MonoBehaviour {

    public Transform pickUpSassoTransform;
    private bool nothingInHand;
    private bool throwing;
    private GameObject rock;

	void Start () {
        nothingInHand = true;
        throwing = false;

    }
	
	void Update () {
        if(!nothingInHand && Input.GetKeyUp(KeyCode.Mouse0))
        {
            launch();
        }
    }

    private void OnTriggerStay(Collider other)
    {
            if (other.gameObject.tag == "sasso" && Input.GetKeyDown(KeyCode.E) && nothingInHand)
            {
                rock = other.gameObject;
                pickUp(other.gameObject);
                nothingInHand = false;
            }
    }

    private void launch()
    {
        nothingInHand = true;
        rock.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        rock.transform.parent = null;

        rock.transform.Rotate(0f, 0f, 45f);
        rock.GetComponent<Rigidbody>().AddForce(new Vector3(1,1,0f) * 400f);
    }

    private void pickUp(GameObject sasso)
    {
        sasso.transform.SetParent(gameObject.transform);
        sasso.transform.SetAsFirstSibling();
        sasso.transform.position = pickUpSassoTransform.position;
        sasso.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
    }
}
