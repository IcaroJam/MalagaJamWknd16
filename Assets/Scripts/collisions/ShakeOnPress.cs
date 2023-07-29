using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeOnPress : MonoBehaviour
{
    public float intensity;

    // Start is called before the first frame update
    void Start()
    {
        intensity = FindObjectOfType<ShakeBody>().shakeFrequency;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            FindObjectOfType<ShakeBody>().CameraShake();
        if (Input.GetKeyUp(KeyCode.W))
            FindObjectOfType<ShakeBody>().StopShake();
    }
}
