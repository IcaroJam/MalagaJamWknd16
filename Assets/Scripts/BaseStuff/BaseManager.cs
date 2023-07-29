using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseManager : MonoBehaviour
{
	private GameObject	_Base1;
	private GameObject	_Base2;
	private GameObject	_Base3;
	public uint			Base1SpawnTime;
	public uint			Base2SpawnTime;
	public uint			Base3SpawnTime;

    // Start is called before the first frame update
    void Start()
    {
		_Base1 = GameObject.Find("BasePivot1");
		_Base2 = GameObject.Find("BasePivot2");
		_Base3 = GameObject.Find("BasePivot3");
		
		_Base1.SetActive(false);
		_Base2.SetActive(false);
		_Base3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad > Base1SpawnTime)
			_Base1.SetActive(true);
        if (Time.timeSinceLevelLoad > Base2SpawnTime)
			_Base2.SetActive(true);
	    if (Time.timeSinceLevelLoad > Base3SpawnTime)
			_Base3.SetActive(true);
    }
    
    void Awake()
    {

    }
}
