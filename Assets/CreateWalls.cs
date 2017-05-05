using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWalls : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        getInput();
	}

    void getInput()
    {
        if(GvrViewer.Instance.Triggered == true)
        {

        }
    }
}
