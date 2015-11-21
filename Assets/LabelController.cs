using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LabelController : MonoBehaviour {

	public MidiOptions controller;
	public int id;
	public Text label;
	public Button buttonComponent;

	void Start()
	{
		buttonComponent = GetComponent<Button> ();
		buttonComponent.onClick.AddListener(delegate { buttonClicked(); });
	}

	void buttonClicked()
	{
		controller.setValueToLabel(this);
	}
}
