using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DoorInteraction : MonoBehaviour {

	private float timer=0;
	public float gazeTime = 2f;

	private bool gazedAt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (gazedAt == true) {
			timer += Time.deltaTime;

			if (timer >= gazeTime) {
				ExecuteEvents.Execute (gameObject, new PointerEventData (EventSystem.current), ExecuteEvents.pointerDownHandler);
				timer = 0f;

//				GetComponent<Collider> ().enabled = false;

			}
		}
		
	}

	public void PointerEnter(){
		
		gazedAt = true;
	}

	public void PointerExit(){
		
		gazedAt = false;
	}

//	public void PointerDown(){
//		Debug.Log ("Pointer Down");
//	}
}
