﻿using UnityEngine;

public class Tank : MonoBehaviour {
	public float m = 100;
	public Position p;
	public float i;
	void Start() {
		p = new Position(this.transform.position.x, this.transform.position.z);
		i = m * (Mathf.Pow(this.GetComponent<Renderer>().bounds.size.x, 2) + 
			Mathf.Pow(this.GetComponent<Renderer>().bounds.size.z, 2)) / 12f;
	}
}
