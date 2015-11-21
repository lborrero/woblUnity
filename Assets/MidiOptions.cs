using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class MidiOptions : MonoBehaviour {

	public GameObject Container;
	public GameObject Label;
	private List<GameObject> options = new List<GameObject>(); 
	public Text currentlabelIndex;

	void Start () {
		for (int i = 0; i < 128; i++) 
		{
			options.Add(Instantiate(Label, new Vector3(0, 0, 0), Quaternion.identity) as GameObject);
		}
		for (int i = 0; i < options.Count; i++) 
		{
			options[i].transform.parent = this.transform;
			options[i].GetComponent<LabelController>().controller = this;
			options[i].GetComponent<LabelController>().id = i;
			options[i].GetComponent<LabelController>().label.text = i.ToString();
			options[i].transform.localScale = new Vector3(1, 1, 1);
		}
	}
	
	public void setCurrenLabel(Text _cl)
	{
		currentlabelIndex = _cl;
		Container.SetActive (true);
	}
	
	public void setValueToLabel(LabelController value)
	{
		currentlabelIndex.text = value.label.text;
		Container.SetActive (false);
	}
}
