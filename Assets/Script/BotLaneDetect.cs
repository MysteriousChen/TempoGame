using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotLaneDetect : MonoBehaviour {

    public UiManager ui;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D point)
    {
        if(point.gameObject.tag == "tail")
            //在每個鋼琴塊的最尾端加一個tag = "tail" 的物件。
        {
            ui.YouLose();
        }
    }

}
