using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public Text text;
	
	void Start () {
		text = GetComponent<Text> ();
	
	}

	void Update () {
		text.text = GameController.GC.score.ToString();
	
	}
}
