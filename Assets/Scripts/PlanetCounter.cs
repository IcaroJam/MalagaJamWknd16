using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetCounter : MonoBehaviour
{
	private uint					_hits = 0;
	[SerializeField] private float	_hitsToEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnCollisionEnter2D(Collision2D col)
	{
		_hits++;

		if (_hits >= _hitsToEnd) {
			Debug.Log("EARTH'S DEAD!");
			SceneManager.LoadScene("BadEnding");
		}
	}

	public uint Hits => _hits;
}
