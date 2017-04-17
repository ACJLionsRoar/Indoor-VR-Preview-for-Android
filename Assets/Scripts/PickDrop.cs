using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickDrop : MonoBehaviour {

	private bool pickedUp;
	private GameObject Reticle;

	private Color originalColor;

	public int pickupDistance=4;

//	private Material[] originalMaterial;
//	private Material mat;

	// Use this for initialization
	void Start () {
//		mat = new Material(Shader.Find("Specular"));
//		mat.color = Color.blue;

		pickedUp = false;
		Reticle = GameObject.Find ("GvrReticle");
		originalColor = GetComponent<Renderer> ().material.color;
//		originalMaterial=GetComponent<Renderer>().materials;




		
	}
	
	// Update is called once per frame
	void Update () {
		if (pickedUp) {
			Ray ray = new Ray (Reticle.transform.position, Reticle.transform.forward);
			transform.position = ray.GetPoint (pickupDistance);
		}
		
	}

	public void PointerDown(){

		pickedUp = true;
	
		GetComponent<Renderer> ().material.color = Color.blue;
		
//			GetComponent<Renderer>().materials[0]=mat;
			
	}

	public void Select(){

		pickedUp = false;
		
		GetComponent<Renderer> ().material.color = originalColor;
	
//			GetComponent<Renderer>().materials=originalMaterial;
	}
}
