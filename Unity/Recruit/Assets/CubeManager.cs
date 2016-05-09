﻿using UnityEngine;
using System.Collections;

public class CubeManager : MonoBehaviour {
	public Rigidbody rb;
	public float speed = 0f;
	public float rotate = 1f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		if (Input.GetKey (KeyCode.W)) {
			rb.AddForce(transform.forward * speed);
		}
		if(Input.GetKey (KeyCode.A)){
			transform.eulerAngles += new Vector3 (0, -rotate, 0);
		}
		if(Input.GetKey (KeyCode.D)){
			transform.eulerAngles += new Vector3 (0, rotate, 0);
		}
		if (Input.GetKey (KeyCode.S)) {
			speed += 2f;
			rb.AddForce (transform.forward * -speed);
			if (speed > 20) {
				speed = 20f;
			}
		}

		if(speed > 180){
			speed = 180f;
		}
		speed -= 1f;
		if (speed < 0) {
			speed = 0f;
		}
	}
}
