using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class CameraFix : MonoBehaviour {
    [Range(1, 4)]
    public int pixelscale = 1;

    private Camera camera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(camera == null){
            camera = camera.GetComponent<Camera>();
            camera.orthographic = true;
        }
        camera.orthographicSize = Screen.height * (0.005f / pixelscale);
	}
}
