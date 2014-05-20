using UnityEngine;
using System.Collections;

public class MGFlashCleanUp : MonoBehaviour {

	private float selfTerminate = .2f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		selfTerminate -= Time.deltaTime;
		if (selfTerminate < 0) {DestroyObject(this.gameObject);}
		
	}
}