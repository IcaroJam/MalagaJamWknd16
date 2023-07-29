using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseControl : MonoBehaviour
{
	private float	_speed;
	public float	accel;
	public float	deccel;
	public float	maxSpeed;

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
			_speed += accel;
		else if (Input.GetKey(KeyCode.S))
			_speed -= accel;
		else
			_speed = Mathf.Lerp(_speed, 0, Time.deltaTime * deccel);

		_speed = Mathf.Clamp(_speed, -maxSpeed, maxSpeed);	

		transform.Rotate(Vector3.forward * _speed * Time.deltaTime);
	}
}
