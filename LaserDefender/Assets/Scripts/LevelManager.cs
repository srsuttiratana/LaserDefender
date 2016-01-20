using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void loadLevel(string name)
	{
		Debug.Log ("Level requested: " + name);
		Brick.breakableCount = 0;
		Application.LoadLevel (name);
	}

	public void quitRequest()
	{
		Debug.Log ("Quit requested.");
		Application.Quit ();
	}

	public void LoadNextLevel(){
		Brick.breakableCount = 0;
		Application.LoadLevel (Application.loadedLevel+1);
	}

	public void BrickDestroyed(){
		if (Brick.breakableCount <= 0){
			LoadNextLevel();
		}
	}
}
