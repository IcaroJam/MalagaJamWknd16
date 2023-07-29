using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeBody : MonoBehaviour
{
    private Vector3 _originalPos;
    public float shakeFrequency = default;
    // Start is called before the first frame update
    void Start()
    {
        _originalPos = transform.position;
    }
    
    public IEnumerator CameraShake()
    {
		float	secs = 0;

		while (secs < 0.2f) {
        	transform.position = _originalPos + Random.insideUnitSphere * shakeFrequency;
			secs += Time.deltaTime;
			yield return null;
		}
		StopShake();
    }

    public void StopShake()
    { 
        transform.position = _originalPos;
		StopAllCoroutines();
    }

	void OnCollisionEnter2D(Collision2D col)
	{
		StartCoroutine(CameraShake());
	}
}
