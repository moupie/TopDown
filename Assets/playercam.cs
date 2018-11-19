using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercam : MonoBehaviour {

    public GameObject bob;
	// Use this for initialization
	void Start () {
        bob = GameObject.FindWithTag("bob");
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
