using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadEndingLore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		FindObjectOfType<TextTyper>().printText("Pruebita");
		StartCoroutine(WaitAndPrint());
    }

	IEnumerator WaitAndPrint()
	{
		yield return new WaitForSeconds(5);
		FindObjectOfType<TextTyper>().printText("Otro coso");
	}
}
