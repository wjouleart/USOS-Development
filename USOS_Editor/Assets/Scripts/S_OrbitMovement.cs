using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_OrbitMovement : MonoBehaviour
{
    float orbitRotation;
    
    
    void Start()
    {
        // Default Value
        orbitRotation = 0;    
    }

    void Update()
    {
        orbitRotation += 0.1f;

        transform.rotation = Quaternion.Euler(0, orbitRotation, 0);
    }
}
