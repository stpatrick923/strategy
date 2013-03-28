using UnityEngine;
using System.Collections;

public class UserCamera : MonoBehaviour {
	public float speed = 0.5F;
	public float sensitivity = 15.0F;
	private float xEdge = 32F;
	private float yEdge = 20F;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var pos = this.transform.position;
		if (Input.mousePosition.x < sensitivity && pos.x < xEdge) {
			//move camera left
			pos.x += speed;
		}
		else if (Input.mousePosition.x > Screen.width - sensitivity && pos.x > -xEdge) {
			//move camera right
			pos.x -= speed;
		}
		if (Input.mousePosition.y < sensitivity && pos.y > -yEdge) {
			// move camera down
			pos.y -= speed;
		}
		else if (Input.mousePosition.y > Screen.height - sensitivity && pos.y < yEdge) {
			// move camera up
			pos.y += speed;
		}
		this.transform.position = pos;
	}
	
	
}
