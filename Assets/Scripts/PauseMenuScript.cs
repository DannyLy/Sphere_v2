using UnityEngine;
using System.Collections;

public class PauseMenuScript : MonoBehaviour {

	public GameObject pauseMenuPanel;
	private Animator transition;
	private bool isPaused = false;

	// Use this for initialization
	void Start () {
		//unpause the game on start
		Time.timeScale = 1;
		//get the animator
		transition = pauseMenuPanel.GetComponent<Animator>();
		transition.enabled = false;
	}
	
	// Update is called once per frame
	public void Update () {
		//pause the game on esc key press 
		if(Input.GetKeyUp(KeyCode.Escape) && !isPaused){
			PauseGame();
		}
		//unpause the game 
		else if(Input.GetKeyUp(KeyCode.Escape) && isPaused){
			UnpauseGame();
		}
	}
	
	//function to pause the game
	public void PauseGame(){
		transition.enabled = true;
		transition.Play("PauseMenuSlideIn");
		isPaused = true;
		Time.timeScale = 0;
	}
	//unpause the game
	public void UnpauseGame(){
		isPaused = false;
		transition.Play("PauseMenuSlideOut");
		Time.timeScale = 1;
	}
	
}