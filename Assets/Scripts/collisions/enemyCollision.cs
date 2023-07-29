using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

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
        if (collision.gameObject.name == "Planet")
        {
            Destroy(gameObject);
        }
        else if (collision.transform.GetComponent<Shoot>() || collision.gameObject.name == "Shield")
            Destroy(gameObject);
		else if (collision.transform.GetComponent<Projectile>())
			Destroy(gameObject);
    }
}
