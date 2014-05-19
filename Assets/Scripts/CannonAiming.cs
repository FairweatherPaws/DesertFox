using UnityEngine;
using System.Collections;

public class CannonAiming : MonoBehaviour {

	public Camera mainCamera;
	public float angleLimit, angleLimitMod;
	public GameObject panzer;

	// Use this for initialization
	void Start () {
		angleLimit = 20;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (panzer.transform.rotation.eulerAngles.z < 90 && panzer.transform.rotation.eulerAngles.z > -90) {angleLimitMod = panzer.transform.rotation.eulerAngles.z;}
	
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = -0.5f;
		
		Vector3 objectPos = mainCamera.camera.WorldToScreenPoint (transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;
		
		float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
		if (angle > angleLimit + angleLimitMod) {angle = angleLimit + angleLimitMod; }
		if (angle < angleLimitMod) {angle = angleLimitMod;}
		transform.rotation = Quaternion.Euler(new Vector3(0,0,angle));

	}
}
