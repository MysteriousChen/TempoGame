﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapControl : MonoBehaviour {
    public UiManager ui;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }


    void OnMouseDown()
    {
        if (ui.isPlaying)
        {
            this.gameObject.SetActive(false);
            ui.score += 1;
        }
    }
}
