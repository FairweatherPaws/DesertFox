using UnityEngine;
using System.Collections;

public class TankMovement : MonoBehaviour {

	public float maxSpeed, horizV;

	// Use this for initialization
	void Start () {
	
		maxSpeed = 4;
		horizV = 0;
		rigidbody.centerOfMass = new Vector3(0, -0.4f, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
		float horizMove = Input.GetAxis ("Horizontal");

		if (horizV < maxSpeed/4 && horizMove > 0) {horizV += Time.deltaTime/2;}	// acceleration dependent
		if (horizV < maxSpeed/2 && horizMove > 0) {horizV += Time.deltaTime/2;}	// on current velocity:
		if (horizV < 3*maxSpeed/4 && horizMove > 0) {horizV += Time.deltaTime/2;} // decreases by 25%
		if (horizV < maxSpeed && horizMove > 0) {horizV += Time.deltaTime/2;}		// per quarter
		if (horizV > -maxSpeed/2 && horizMove < 0) {horizV -= Time.deltaTime/2;}	// reverse speed and
		if (horizV > -maxSpeed/4 && horizMove < 0) {horizV -= Time.deltaTime/2;}	// acceleration halved
		
		if (horizMove <= 0) {				
			if (horizV > 0) {horizV -= Time.deltaTime;}
		}

		if (horizMove >= 0) {				
			if (horizV < 0) {horizV += Time.deltaTime;}
		}

		if (horizMove == 0 && horizV > -0.1 && horizV < 0.1) {horizV = 0;}

		if (horizV > maxSpeed) { horizV = maxSpeed; }
		if (horizV < -maxSpeed/2) { horizV = -maxSpeed/2; }
		transform.Translate(horizV/50, 0, 0, Space.World);

	}
}
