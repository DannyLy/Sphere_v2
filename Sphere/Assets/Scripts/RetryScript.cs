using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RetryScript : MonoBehaviour {
	
	public Button yesText;
	public Button noText;

	void Start () {
		yesText = yesText.GetComponent<Button> ();
		noText = noText.GetComponent<Button> ();
	}
	
	public void StartLevel() {
		Application.LoadLevel ("Level_Endless");
	}
	
	public void goToMenu() {
		Application.LoadLevel ("Menu");
	}
	
}
