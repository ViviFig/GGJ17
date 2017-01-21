using UnityEngine;
using System.Collections;

public class Cuoricino : MonoBehaviour {

    private bool floating;
    private float t;
    
    void Start()
    {
        floating = true;
    }

	void Update () {
        transform.Rotate(0f, 80f * Time.deltaTime, 0f);

        if (floating)
        {
            floatingUp();
        }else
        {
            floatingDown();
        }
	}

    private void floatingUp()
    {
        t += 0.01f;
        transform.position = new Vector3(transform.position.x,
                                         Mathf.SmoothStep(1f, 0.5f, t),
                                         transform.position.z);

        if (transform.position == new Vector3(transform.position.x,
                                             0.5f,
                                             transform.position.z))
        {
            floating = false;
            t = 0f;
        }
             
    }

    private void floatingDown()
    {
        t += 0.01f;

        transform.position = new Vector3(transform.position.x,
                                         Mathf.SmoothStep(0.5f, 1f, t),
                                         transform.position.z);

        if (transform.position == new Vector3(transform.position.x,
                                             1f,
                                             transform.position.z))
        {
            floating = true;
            t = 0f;
        }
    }
}
