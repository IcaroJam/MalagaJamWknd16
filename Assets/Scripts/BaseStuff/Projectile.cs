using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	private string							_parentName;
    [SerializeField] private Rigidbody2D	_rb;
	[SerializeField] private float			_speed;

	public void Init(Vector2 dir, string parName)
	{
		_parentName = parName;
		_rb.velocity = dir * _speed;

		Destroy(gameObject, 3);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.transform.gameObject.name != _parentName)
			Destroy(gameObject);
	}
}
