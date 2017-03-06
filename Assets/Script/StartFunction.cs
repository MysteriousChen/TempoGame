using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFunction : MonoBehaviour {
    public GameObject music;
    public UiManager ui;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        music.SetActive(true);
        ui.isPlaying = true;
        this.gameObject.SetActive(false);
    }

}
