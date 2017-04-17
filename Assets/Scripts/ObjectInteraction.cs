using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectInteraction : MonoBehaviour {

	private float timer=0;
	public float pickupTime = 3f;
	public float dropTime = 6f;

	private bool gazedAt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (gazedAt == true) {
			timer += Time.deltaTime;

			if (timer >= pickupTime && timer <= dropTime) {
				ExecuteEvents.Execute (gameObject, new PointerEventData (EventSystem.current), ExecuteEvents.pointerDownHandler);
//				Debug.Log ("Picked Up Event");

//				GetComponent<Collider> ().enabled = false;

			} else if (timer > dropTime) {
				ExecuteEvents.Execute (gameObject, new PointerEventData (EventSystem.current), ExecuteEvents.selectHandler);
//				Debug.Log ("Dropped Event");
				timer = 0f;
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
