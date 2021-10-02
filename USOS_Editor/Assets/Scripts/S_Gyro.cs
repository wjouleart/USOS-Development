using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Gyro : MonoBehaviour
{
    float angleX;

    public static float f_OrbitSpeed;
    float f_SmoothVelocity;



    void Start()
    {
        // Default value
        f_OrbitSpeed = 1.0f;
    }


    void FixedUpdate()
    {
        // if (Input.touchCount == 2)
        if (Input.GetKey(KeyCode.Space))
        {
            f_OrbitSpeed = Mathf.SmoothDamp(f_OrbitSpeed, 10.0f, ref f_SmoothVelocity, 2.0f);
        }
        else
        {
            if (f_OrbitSpeed > 1.0001f)
            {
                f_OrbitSpeed = Mathf.SmoothDamp(f_OrbitSpeed, 1.0f, ref f_SmoothVelocity, 2.0f);
            }
        }

        Debug.Log(f_OrbitSpeed);
    }

    /*
    void Update()
    {
        angleX = Input.acceleration.x * 60;

        transform.rotation = Quaternion.Euler(0, angleX, 0);

    }
    */
}
