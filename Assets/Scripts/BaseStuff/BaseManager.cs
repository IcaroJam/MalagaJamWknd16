using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseManager : MonoBehaviour
{
	private GameObject		_Base1;
	private GameObject		_Base2;
	private GameObject		_Base3;
	private	enemy_Generator	_FoeGenerator;
	private uint			_stage = 0;
	public uint				Base1SpawnTime;
	public uint				Base2SpawnTime;
	public uint				Base3SpawnTime;
	public uint				EndTime;

    // Start is called before the first frame update
    void Start()
    {
		_Base1 = GameObject.Find("BasePivot1");
		_Base2 = GameObject.Find("BasePivot2");
		_Base3 = GameObject.Find("BasePivot3");
		_FoeGenerator = FindObjectOfType<enemy_Generator>();
		
		_Base1.SetActive(false);
		_Base2.SetActive(false);
		_Base3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
		if (Time.timeSinceLevelLoad > EndTime) {
			// Change to endscreen
			this.gameObject.SetActive(false);
		} else if (Time.timeSinceLevelLoad > Base3SpawnTime) {
			_Base3.SetActive(true);
		} else if (Time.timeSinceLevelLoad > Base2SpawnTime && _stage == 1) {
			_Base2.SetActive(true);
			_FoeGenerator.spawnTime1 /= 2;
			_FoeGenerator.spawnTime2 /= 2;
			_FoeGenerator.spawnTime3 /= 2;
			_stage++;
		} else if (Time.timeSinceLevelLoad > Base1SpawnTime && _stage == 0) {
			_Base1.SetActive(true);
			_stage++;
		}
    }
    
    void Awake()
    {

    }
}
