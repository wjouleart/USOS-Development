using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_Particles : MonoBehaviour
{
    public ParticleSystem emitter; //Particles emitter
    public float distFromCam = 10; //distance of the emitter from the camera
    J_ObjectPooler objectPooler;
    public bool clicking;
    private void Start()
    {
        objectPooler = J_ObjectPooler.Instance;
    }
    public void Update()

    {

        if (Input.GetMouseButtonDown(0))
        {

            clicking = true;
        }
        if (clicking == true)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distFromCam)); //position when touched/clicked
            emitter.transform.position = pos;
            objectPooler.SpawnFromPool("Particles", pos, Quaternion.identity);
            clicking = false;

        }

    }
}
