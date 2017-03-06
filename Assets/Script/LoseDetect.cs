using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseDetect : MonoBehaviour {

    public UiManager ui;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
        
        if (ui.isPlaying)
        {
            Debug.Log("You Lose!!!!!!!!!");
            ui.isPlaying = false;
        }

    }
}
