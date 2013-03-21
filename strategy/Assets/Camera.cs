using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
	public float speed = 1.0F;
	public float sensitivity = 15.0F;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.mousePosition.x < sensitivity /* && edgeNotReached */) {
			//move camera left
		}
		if (Input.mousePosition.x > max - sensitivity /* && edgeNotReached */) {
			//move camera right
		}
		if (Input.mousePosition.y < sensitivity /* && edgeNotReached */) {
			// move camera down
		}
		if (Input.mousePosition.y > max - sensitivity /* && edgeNotReached */) {
			// move camera up
		}
	}
}
