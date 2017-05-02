using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Triggered - button
        // Tilted - self-explanatory
		if (GvrViewer.Instance.Tilted | GvrViewer.Instance.Triggered)
        {
            Application.Quit(); // This will exit the app
        }
	}
}
