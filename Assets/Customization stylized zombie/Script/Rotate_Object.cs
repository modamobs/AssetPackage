using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Object : MonoBehaviour {
	public float rotSpeed = 20;
	void OnMouseDrag ()
	{
		float rotX = Input.GetAxis("Mouse X")*rotSpeed*Mathf.Deg2Rad;
		this.transform.RotateAround (Vector3.up, rotX);
	}
}
