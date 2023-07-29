using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Generator : MonoBehaviour
{   
    [SerializeField] private GameObject enemy1;
    [SerializeField] private GameObject enemy2;
    [SerializeField] private GameObject enemy3;
    [SerializeField] private Transform[] zones;
    public float spawnTime1;
    public float spawnTime2;
    public float spawnTime3;

    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine(SpawnEnemy1());
		StartCoroutine(SpawnEnemy2());
		StartCoroutine(SpawnEnemy3());
    }

    IEnumerator SpawnEnemy1()
    {
		while (true) {
			yield return new WaitForSeconds(spawnTime1);
        	Instantiate(enemy1, OneRandomZone(), Quaternion.identity);
		}
    }

    IEnumerator SpawnEnemy2()
    {
        while (true) {
			yield return new WaitForSeconds(spawnTime2);
        	Instantiate(enemy2, OneRandomZone(), Quaternion.identity);
		}
    }

    IEnumerator SpawnEnemy3()
    {
        while (true) {
			yield return new WaitForSeconds(spawnTime3);
        	Instantiate(enemy3, OneRandomZone(), Quaternion.identity);
		}
    }

    private Vector3 OneRandomZone()
    {
        return zones[Random.Range(0, zones.Length)].position;
    }
}
