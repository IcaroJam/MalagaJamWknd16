using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Generator : MonoBehaviour
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
        InvokeRepeating("SpawnEnemy1", 0f, spawnTime);
        InvokeRepeating("SpawnEnemy2", 0f, spawnTime2);
        InvokeRepeating("SpawnEnemy3", 0f, spawnTime3);
    }

    private void SpawnEnemy1()
    {
        Instantiate(enemy1, new Vector2(Random.Range(-15f, 15f), Random.Range(-15f, 15f)), Quaternion.identity);
    }

    private void SpawnEnemy2()
    {
        Instantiate(enemy2, new Vector2(Random.Range(-30f, 30f), Random.Range(-30f, 30f)), Quaternion.identity);
    }

    private void SpawnEnemy3()
    {
        Instantiate(enemy3, new Vector2(Random.Range(-30f, 30f), Random.Range(-30f, 30f)), Quaternion.identity);
    }
}
