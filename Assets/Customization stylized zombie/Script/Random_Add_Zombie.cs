using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Add_Zombie : MonoBehaviour {
	public GameObject zombie;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp(){
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit)) {
			Vector3 point = new Vector3 (hit.point.x, zombie.transform.position.y, hit.point.z);
			zombie.transform.position = point;
			Instantiate (zombie);
		}

	}
}
