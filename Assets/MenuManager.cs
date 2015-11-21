using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	public GameObject MainMenu;
	public GameObject Step1;
	public GameObject Step2;

	enum ScreenTypes
	{
		MainMenu = 0,
		Step1,
		Step2
	}

	public void changeMenuState(int screenType)
	{
		Debug.Log (screenType);
		switch((ScreenTypes)screenType)
		{
		case ScreenTypes.MainMenu:
		{
			MainMenu.SetActive(true);
			Step1.SetActive(false);
			Step2.SetActive(false);
			break;
		}
		case ScreenTypes.Step1:
		{
			MainMenu.SetActive(false);
			Step1.SetActive(true);
			Step2.SetActive(false);
			break; 
		}
		case ScreenTypes.Step2:
		{
			MainMenu.SetActive(false);
			Step1.SetActive(false);
			Step2.SetActive(true);
			break; 
		}
		}
	}
}
