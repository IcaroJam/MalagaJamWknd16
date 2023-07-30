using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadEndingLore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		FindObjectOfType<TextTyper>().printText("The impacts absolutely obliterated some of the most iconic places...\n Like Tokyo, Hawaii and Fuengirola...");
		StartCoroutine(WaitAndPrint());
    }

	IEnumerator WaitAndPrint()
	{
		yield return new WaitForSeconds(22);
		FindObjectOfType<TextTyper>().printText("Oh... And the Earth exploded.");
	}
}
