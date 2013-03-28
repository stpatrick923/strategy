using UnityEngine;
using System.Collections;

public class ClickController : MonoBehaviour {
	private bool selected = false;
	private bool move = false;
	public bool clicked = false;
	public float speed = 2.0F;
	private Vector3 targetPosition;
	GameObject target;
	// Use this for initialization
	void Start () {
		targetPosition = transform.position;
		this.transform.LookAt(targetPosition + Vector3.up);
	}
	
	// Update is called once per frame
	void Update () {
		print (clicked);
		if (clicked) {
			selected = true;
			clicked = false;
		}
		else {
			
			if (selected && Input.GetMouseButtonDown(0))
			{
				print ("here");
				Ray clickRay = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit hit = new RaycastHit();
				if (Physics.Raycast(clickRay, out hit)) {
					move = true;
					targetPosition = hit.point;
					targetPosition.z = 0F;
					GameObject.Destroy(target);
					target = UnityEngine.Renderer.Instantiate(Resources.Load("Click Location", typeof(GameObject)), targetPosition, new Quaternion(0,0,0,0)) as GameObject;
				}
				else {
					move = false;
				}
			}
			else if (Input.GetMouseButtonDown(1))
			{
				selected = false;
			}
			if (move) {
				if (Vector3.Distance(transform.position, targetPosition) < 0.1) {
					transform.position = targetPosition;
					GameObject.Destroy(target);
					move = false;
				}
				else {
					transform.LookAt(targetPosition);
					transform.Translate(Vector3.forward * Time.deltaTime * speed);
				}
			}
			//print(targetPosition + "          " + transform.position);
			//this.transform.Rotate(targetPosition.Normalize);
		}
	}
	
	void OnMouseDown() {
		GameObject[] ships = GameObject.FindGameObjectsWithTag("Ship");
		for (int i = 0; i < ships.Length; i++) {
			ClickController shipController = (ClickController)ships[i].GetComponent("ClickController");
			shipController.deselect();
		}
		clicked = true;
	}
		
	public void deselect() {
		selected = false;
	}
}
