using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour {
	

	public void Restart()
	{
		Application.LoadLevel(Application.loadedLevel);
	}

	public void LevelSelect(){
		Application.LoadLevel ("LevelSelect");
	}

	public void Menu(){
		Application.LoadLevel ("Menu");
	}
	
	public void Quit(){
		Application.Quit ();
	}

}
