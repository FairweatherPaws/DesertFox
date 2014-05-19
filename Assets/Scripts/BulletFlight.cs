using UnityEngine;
using System.Collections;

public class BulletFlight : MonoBehaviour {
	
	private float lifeSpan = 5f;
	public GameObject cannon;
	public float angle;
	
	// Use this for initialization
	
	void Awake () {
		this.rigidbody.AddRelativeForce(700,0,0);
		
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
			
			Destroy(this.gameObject);
			
			// damage dealing here
			
		}
	}
}
