using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMove : MonoBehaviour {

    public UiManager ui;
    public GameObject KeyBoard;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ui.isPlaying)
        {
            KeyBoard.gameObject.transform.position -= new Vector3(0f, speed, 0f);
        }
    }
}
