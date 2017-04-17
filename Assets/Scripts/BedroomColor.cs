using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomColor : MonoBehaviour {

//	GameObject wall;

	Material[] mats;

	public void changeColor(Material toColor){
		
			
//		wall = GameObject.FindWithTag ("outdoorWalls");
//
//		if (wall == null)
//			Debug.Log ("Didnt find wall");
//		else {
//			Debug.Log ("Got wall");
//			wall = GetComponent<Renderer>();
//			wall.
//

		mats = GetComponent<Renderer>().materials;
		mats [1] = toColor;
		mats [2] = toColor;
		mats [3] = toColor;
		GetComponent<Renderer> ().materials = mats;

		Debug.Log ("Color Script Executed");

//		}
			

		
		
		
	}
}
