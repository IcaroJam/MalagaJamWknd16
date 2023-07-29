using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCollision : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "Planet") {
            Destroy(enemy);
        }
        else if (collision.gameObject.name == "Base") {
            Destroy(enemy);
        }
    }

}
