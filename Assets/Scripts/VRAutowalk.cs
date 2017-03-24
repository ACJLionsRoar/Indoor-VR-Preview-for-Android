

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class VRAutowalk : MonoBehaviour {
	// How fast to move
	public float speed = 3.0F;
	// Should I move forward or not
	private bool moveForward ;
	[Tooltip("Activate this checkbox if the player shall move when he looks below the threshold.")]
	public bool walkWhenLookDown;
	[Tooltip("This has to be an angle from 0° to 90°")]
	public double thresholdAngle;
	// CharacterController script
	private CharacterController controller;
	// GvrViewer Script
	//private GvrViewer gvrViewer;
	// VR Head
	private Transform vrHead;

	private const int RIGHT_ANGLE = 90;

	// Use this for initialization
	void Start () {
		// Find the CharacterController
		controller = GetComponent<CharacterController>();
		// Find the GvrViewer on child 0
		//gvrViewer = transform.GetChild(0).GetComponent<GvrViewer>();
		// Fnd the VR Head
		vrHead = Camera.main.transform;
	}

	// Update is called once per frame
	void Update () {

		if (walkWhenLookDown  && !moveForward &&
			vrHead.transform.eulerAngles.x >= thresholdAngle &&
			vrHead.transform.eulerAngles.x <= RIGHT_ANGLE)
		{
			moveForward = true;
		}
		else if (walkWhenLookDown && moveForward &&
			(vrHead.transform.eulerAngles.x <= thresholdAngle ||
				vrHead.transform.eulerAngles.x >= RIGHT_ANGLE))
		{
			moveForward = false;
		}

		// Check to see if I should move
		if (moveForward) {
			// Find the forward direction
			Vector3 forward = vrHead.TransformDirection(Vector3.forward);
			// Tell CharacterController to move forward
			controller.SimpleMove(forward * speed);
		}
	}
}