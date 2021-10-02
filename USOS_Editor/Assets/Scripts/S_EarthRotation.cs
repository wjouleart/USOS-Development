using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_EarthRotation : MonoBehaviour
{
    float f_EarthRotation;



    void Start()
    {
        // Default Value
        f_EarthRotation = 90.0f;
    }


    void Update()
    {
        // 1 deltatime = 0.0167 degrees
        // Required 360 degrees to rotate around, takes 120 secs (2 mins)
        f_EarthRotation += Time.deltaTime * 3;

        transform.rotation = Quaternion.Euler(-97.5f, f_EarthRotation, -67.5f);
    }
}
