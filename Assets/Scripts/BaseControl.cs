using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseControl : MonoBehaviour
{
	public float	speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

	void HandleMovement()
	{
		if (Input.GetKey(KeyCode.A))
			transform.Rotate(Vector3.forward * speed * Time.deltaTime);
		if (Input.GetKey(KeyCode.S))
			transform.Rotate(Vector3.back * speed * Time.deltaTime);
	}
}
