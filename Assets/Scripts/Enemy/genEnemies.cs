using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genEnemies : MonoBehaviour
{   
    [SerializeField] private GameObject enemy1;
    [SerializeField] private GameObject enemy2;
    [SerializeField] private GameObject enemy3;
    [SerializeField] private float spawnTime = 3f;
    [SerializeField] private float spawnTime2 = 4f;
    [SerializeField] private float spawnTime3 = 6f;

    // Start is called before the first frame update
    void Start()
    { 
        enemy1 = GameObject.Find("enemy_1");
        enemy2 = GameObject.Find("enemy_2");
        enemy3 = GameObject.Find("enemy_3");
        StartCoroutine(SpawnEnemy(spawnTime, enemy1));
        StartCoroutine(SpawnEnemy(spawnTime2, enemy2));
        StartCoroutine(SpawnEnemy(spawnTime3, enemy3));

    }

    private IEnumerator SpawnEnemy(float spawnTime, GameObject enemy1)
    {
        yield return new WaitForSeconds(spawnTime);
        GameObject newEnemy = Instantiate(enemy1, new Vector2(Random.Range(-30f, 30f), Random.Range(-30f, 30f)), Quaternion.identity);
        StartCoroutine(SpawnEnemy(spawnTime, enemy1));
        GameObject newEnemy2 = Instantiate(enemy2, new Vector2(Random.Range(-30f, 30f), Random.Range(-30f, 30f)), Quaternion.identity);
        StartCoroutine(SpawnEnemy(spawnTime2, enemy2));
        GameObject newEnemy3 = Instantiate(enemy3, new Vector2(Random.Range(-30f, 30f), Random.Range(-30f, 30f)), Quaternion.identity);
        StartCoroutine(SpawnEnemy(spawnTime3, enemy3));
    }
}