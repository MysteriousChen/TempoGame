using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/////
using UnityEngine.UI;
/////   
        
public class UiManager : MonoBehaviour {
    public Text ScoreText;
    public int score=0;
    public bool isPlaying = false;
//    public Image GameOverImage;
        
    // Use this for initialization
	void Start () {
		
	}   
	    
	// Update is called once per frame
	void Update () {
        ScoreText.text = ""+score;
        
    }   
        
    public void YouLose()
    {   
        isPlaying = false ;
//        GameOverImage.gameObject.SetActive(true) ; 
    }   
        
}       