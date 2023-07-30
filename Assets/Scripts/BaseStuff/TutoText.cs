using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutoText : MonoBehaviour
{
	private TMP_Text		_txtRef;
	public BaseControl[]	_bases;

	void Awake()
	{

	}

    // Start is called before the first frame update
    void Start()
    {
		_txtRef = GetComponent<TMP_Text>();
    	_txtRef.text =	"Inner Turret: " + _bases[0].leftKey + " - " + _bases[0].rightKey +
						" | Outer Turret: " + _bases[1].leftKey + " - " + _bases[1].rightKey +
						" | Shield: " + _bases[2].leftKey + " - " + _bases[2].rightKey;
    }
}
