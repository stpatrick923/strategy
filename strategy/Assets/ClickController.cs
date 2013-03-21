using UnityEngine;
using System.Collections;

public class ClickController : MonoBehaviour {
	private bool selected = false;
	public float smooth = 1.0F;
	private Vector3 targetPosition;
	// Use this for initialization
	void Start () {
		targetPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (selected && Input.GetMouseButtonDown(0))
		{

			targetPosition = Camera.main.ScreenPointToRay(Input.mousePosition).GetPoint(25F);
			targetPosition.z = 0F;
		}
		else if (Input.GetMouseButtonDown(1))
		{
			selected = false;
		}
		this.transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smooth);
		
	}
	
	void OnMouseDown() {
		selected = true;
	}
}
