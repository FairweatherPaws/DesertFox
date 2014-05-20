using UnityEngine;
using System.Collections;

public class BulletFlight : MonoBehaviour {
	
	private float lifeSpan = 5f;
	public GameObject cannon;
	public float angle, damage;
	
	// Use this for initialization
	
	void Awake () {
		this.rigidbody.AddRelativeForce(700,0,0);
		if (rigidbody.mass < 1) {damage = 1;}
		else {damage = 10;}
	}
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		lifeSpan -= Time.deltaTime;
		if (lifeSpan < 0) {Destroy(this.gameObject);}
	}
	
	void OnTriggerEnter (Collider collDetect) {
		
		if (collDetect) {

			unitStats Script1 = collDetect.GetComponent<unitStats>();
			float dealt = Script1.myHP;
			Script1.myHP -= damage;

			if (Script1.myHP >= 0) {Destroy(this.gameObject);}
			else {damage -= dealt; this.rigidbody.AddForce(200,0,0);}

			
			// damage dealing here
			
		}
	}
}
