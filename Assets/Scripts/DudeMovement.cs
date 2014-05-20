using UnityEngine;
using System.Collections;

public class DudeMovement : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(-Time.deltaTime,0,0);
	
	}
}
