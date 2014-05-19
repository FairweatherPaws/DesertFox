using UnityEngine;
using System.Collections;

public class CloudRoll : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		renderer.material.mainTextureOffset += new Vector2(Time.deltaTime/100, 0);

	}
}
