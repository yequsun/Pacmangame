using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public int dotsNumber;
    public static GameController GC;
	public int score;
	

	void Awake(){
		GC = this;
	}
	void Start () {
        GameObject[] pacdots = GameObject.FindGameObjectsWithTag("dot");
		dotsNumber = pacdots.Length;
	
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.R)){
			Application.LoadLevel(Application.loadedLevel);
		}
	
	}
}
