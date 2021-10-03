using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Camera : MonoBehaviour
{
    Gyroscope c_Gyro;
    Quaternion q_GyroRotation;
    float f_RawAngle;
    float f_GyroAngle;
    float f_GyroVelocity;

    public static float f_OrbitSpeed;
    float f_OrbitVelocity;

    Transform t_ZoneTextParent;



    void Awake()
    {
        // Setup Gyroscope
        c_Gyro = Input.gyro;
        c_Gyro.enabled = true;

        t_ZoneTextParent = GameObject.FindWithTag("ZoneText").transform;
    }

    void Start()
    {
        // Default value
        f_OrbitSpeed = 1.0f;
        f_RawAngle = 0;
        f_GyroAngle = 0;

        // Default Smooth Velocity
        f_GyroVelocity = 0;
        f_OrbitVelocity = 0;
    }


    void Update()
    {
        // Accumulate Gyroscope's delta rotation
        f_RawAngle -= c_Gyro.rotationRateUnbiased.y;

        // Smoothen the rotation rate
        f_GyroAngle = Mathf.SmoothDamp(f_GyroAngle, f_RawAngle, ref f_GyroVelocity, 0.2f);

        // Apply to Camera's rotation
        transform.localRotation = Quaternion.Euler(0, f_GyroAngle, 0);
    }


    void FixedUpdate()
    {
        if (Input.touchCount == 2)
        {
            f_OrbitSpeed = Mathf.SmoothDamp(f_OrbitSpeed, 10.0f, ref f_OrbitVelocity, 2.0f);
        }
        else
        {
            if (f_OrbitSpeed > 1.0001f)
            {
                f_OrbitSpeed = Mathf.SmoothDamp(f_OrbitSpeed, 1.0f, ref f_OrbitVelocity, 2.0f);
            }
        }
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.name == "AphelionZone")
        {
            t_ZoneTextParent.GetChild(1).gameObject.SetActive(true);
        }
        else if (other.name == "PerihelionZone")
        {
            t_ZoneTextParent.GetChild(2).gameObject.SetActive(true);
        }
        else if (other.name == "DangerZone")
        {
            t_ZoneTextParent.GetChild(3).gameObject.SetActive(true);
        }

        t_ZoneTextParent.GetChild(0).gameObject.SetActive(false);
    }


    void OnTriggerExit(Collider other)
    {
        // Activate "Safe Zone" Text 
        t_ZoneTextParent.GetChild(0).gameObject.SetActive(true);

        // Deactivate others
        for (int i = 1; i < 4; i++)
        {
            t_ZoneTextParent.GetChild(i).gameObject.SetActive(false);
        }

    }


}
