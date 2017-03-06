using System.Collections;
using System.Collections.Generic;
using UnityEngine;
           
public class MusicControl : MonoBehaviour {


    public UiManager ui;
           
	// Use this for initialization
	void Start () {
    }      
	       
	// Update is called once per frame
	void Update () {        
        if (!ui.isPlaying)
        {
            this.gameObject.SetActive(false);
        }  
           
    }      
           
}          