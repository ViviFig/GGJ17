using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//unity doc test per modificare il component light spot angle nel GO
public class ProbeLightSetTest : MonoBehaviour
{


    public float interval = 0.3F;
    public float minAngle = 10;
    public float maxAngle = 90;
    public float timeLeft;
    public Light lt;
    void Start()
    {
        lt = GetComponent<Light>();
        lt.type = LightType.Spot;
        timeLeft = interval;
    }
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0.0F)
        {
            timeLeft = interval;
            lt.spotAngle = Random.Range(minAngle, maxAngle);
        }
    }
}
