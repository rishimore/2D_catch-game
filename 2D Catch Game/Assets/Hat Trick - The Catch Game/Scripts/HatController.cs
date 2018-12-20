using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatController : MonoBehaviour {

    public Camera cam;
    private float maxWidth;
	private bool canControl;

	private Rigidbody2D rgb;

	// Use this for initialization
	void Start () {
     	if (cam == null){
			cam = Camera.main;
		}
		canControl = false;
        rgb = GetComponent<Rigidbody2D>();
		Vector3 upperCorner = new Vector3 (Screen.width, Screen.height, 0.0f);   
		Vector3 targetWidth = cam.ScreenToWorldPoint (upperCorner);
	    float hatWidth = GetComponent<Renderer>().bounds.extents.x;
	    maxWidth = targetWidth.x - hatWidth;    
	}
	
	void Update () {
		var somevalue = Input.GetAxis ("Horizontal");
	}
	
	// Update is called once physics timestamp
	void FixedUpdate () {
		if (canControl){
		Vector3 rawPosition = cam.ScreenToWorldPoint (Input.mousePosition);
	    Vector3 targetPosition = new Vector3 (rawPosition.x, 0.0f, 0.0f);
	    float targetWidth = Mathf.Clamp (targetPosition.x, -maxWidth, maxWidth); 
	    targetPosition = new Vector3(targetWidth, targetPosition.y, targetPosition.z);
		rgb.MovePosition (targetPosition);
		}
	}

	public void ToggleControl (bool toggle){
		canControl = toggle;
	}
}
