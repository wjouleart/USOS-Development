using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Gyro : MonoBehaviour
{
    float angleX;
    
    
    void Update()
    {
        angleX = Input.acceleration.x * 60;

        transform.rotation = Quaternion.Euler(0, angleX, 0);
    }
}
