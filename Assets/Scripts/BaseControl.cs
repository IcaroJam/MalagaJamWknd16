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
        HandleMovement(Input.GetKey(KeyCode.A), Input.GetKey(KeyCode.S));
    }

	void HandleMovement(bool _left, bool _right)
	{
		if (_left && !_right)
			_speed += accel;
		else if (!_left && _right)
			_speed -= accel;
		else
			_speed = Mathf.Lerp(_speed, 0, Time.deltaTime * deccel);

		_speed = Mathf.Clamp(_speed, -maxSpeed, maxSpeed);	

		transform.Rotate(Vector3.forward * _speed * Time.deltaTime);
	}
}
