using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetParticleSortingLayer : MonoBehaviour {

    public string sortingLayerName;
	public int sortingOrder;
	// Use this for initialization
	void Start () {
		GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = sortingLayerName;
		GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = sortingLayerName;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
