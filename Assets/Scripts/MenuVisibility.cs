using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuVisibility : MonoBehaviour {

	public GameObject menu; // Assign in inspector
	private bool isShowing=true;

	public void switchVisibility(){

		if (isShowing) {
			menu.SetActive (false);
			isShowing = false;
		} else {
			menu.SetActive (true);
			isShowing = true;
		}
		
	}
}
