using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

    public float degreesPerSecond;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Vector3.up is the Y-axis
        // Time.deltaTime is the amount of time that has passed in the frame (fractional value)
        transform.Rotate(Vector3.up * Time.deltaTime * degreesPerSecond);
	}
}
