using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverMenuScript : MonoBehaviour {
	
	public Button menuText;
	public Button exitText;
	
	void Start () {
		menuText = menuText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
	}
	
	public void goToMenu() {
		Application.LoadLevel ("Menu");
	}
	
	public void ExitGame() {
		Application.Quit ();
	}
	
}
