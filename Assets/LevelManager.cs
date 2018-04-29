using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name) {
		Debug.Log ("Level load requested for : " + name);
		Application.LoadLevel (name);
	}

	public void QuitLevel (string name) {
		Debug.Log ("Level quit requested for : " + name);
		Application.Quit();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
