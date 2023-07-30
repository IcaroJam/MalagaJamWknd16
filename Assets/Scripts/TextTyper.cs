using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextTyper : MonoBehaviour
{
	private TMP_Text				_txtRef;
	private string					_textToPrint;
	[SerializeField] private float	_printTime;

	void Awake()
	{
		_txtRef = GetComponent<TMP_Text>();
		_textToPrint = _txtRef.text;
		_txtRef.text = string.Empty;
	}

    // Start is called before the first frame update
    void Start()
    {
		
    }

	public void printText(string toPrint)
	{
		_txtRef.text = string.Empty;
		_textToPrint = toPrint;
		StopAllCoroutines();
		StartCoroutine(printIt());
	}
	
	IEnumerator printIt()
	{
		for (int i = 0; i < _textToPrint.Length; i++) {
			_txtRef.text += _textToPrint[i];
			yield return new WaitForSeconds(_printTime);
		}
		yield return null;
	}
}
