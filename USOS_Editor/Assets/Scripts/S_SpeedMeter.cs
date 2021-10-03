using UnityEngine;

public class S_SpeedMeter : MonoBehaviour
{
    float f_DotRotation;
    RectTransform t_DotTransform;


    void Start()
    {
        // Default value
        f_DotRotation = -60.0f;
        t_DotTransform = GetComponent<RectTransform>();
    }


    void Update()
    {
        // Orbit Speed ranged from Min 1 to Max 10
        // Orbit Speed -1 will be Min 0 to Max 9
        // Meter Rotation ranged from -60 degrees to 60 degrees
        // Meter Rotation Gap = 120 degrees in total
        float f_ModifiedOrbitSpeed = S_Camera.f_OrbitSpeed - 1.0f;
        f_DotRotation = -60.0f + (f_ModifiedOrbitSpeed * 13.333f);

        t_DotTransform.eulerAngles = new Vector3(0, 0, f_DotRotation);
    }
}
