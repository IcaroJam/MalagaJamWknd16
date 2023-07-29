using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3Rotate : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float rotationSpeed = 100.0f;

    void Update()
    {
        // Movimiento del sprite
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        // Rotación del sprite
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}

