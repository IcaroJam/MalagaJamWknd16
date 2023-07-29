using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	[SerializeField] private Projectile		_projectilePrefab;
	[SerializeField] private Rigidbody2D	_rb;
	[SerializeField] private Transform		_spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shoot", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
	
    }

	private void shoot()
	{
		Instantiate(_projectilePrefab, _spawnPoint.position, Quaternion.identity).Init(transform.right, gameObject.name);
	}
}