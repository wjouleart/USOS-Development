using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_OrbitMovement : MonoBehaviour
{
    float f_OrbitRotation;


    void Awake()
    {
        Application.targetFrameRate = 60;
    }


    void Start()
    {
        // Default value
        f_OrbitRotation = 0.0f;
    }


    void Update()
    {
        // 1 frame = 0.0167 degrees
        // 60 frames = 1 degree
        // Required 360 degrees to rotate around, takes 360 secs (6 mins)
        // If accelerated, time taken will be divided by 3. (2 mins)
        f_OrbitRotation += Time.deltaTime * S_Gyro.f_OrbitSpeed;

        transform.rotation = Quaternion.Euler(0, f_OrbitRotation, 0);

    }
}
