using UnityEngine;

public class S_Minimap : MonoBehaviour
{
    float f_DotRotation;
    RectTransform t_DotTransform;


    void Start()
    {
        // Default value
        f_DotRotation = -5.0f;
        t_DotTransform = GetComponent<RectTransform>();
    }


    void Update()
    {
        // 1 deltatime = 0.0167 degrees
        // Required 360 degrees to rotate around, takes 360 secs (6 mins)
        // If accelerated, time taken will be divided by 3. (2 mins)
        f_DotRotation -= Time.deltaTime * S_Camera.f_OrbitSpeed;

        t_DotTransform.eulerAngles = new Vector3(0, 0, f_DotRotation);

    }
}
