using UnityEngine;
using System.Collections;

public class SimpleClick : ClickController {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown() {
		clicked = true;	
		print("here1");
	}
}
