using UnityEngine;
using System.Collections;

public class unitStats : MonoBehaviour {

	public float myHP;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (myHP < 0) {Destroy(this.gameObject);}
	
	}
}
