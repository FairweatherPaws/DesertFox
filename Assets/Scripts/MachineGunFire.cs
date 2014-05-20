using UnityEngine;
using System.Collections;

public class MachineGunFire : MonoBehaviour {
	
	public float startValue, angle, angleLimit, angleLimitMod;
	public Transform bullet;
	public Camera mainCamera;
	public GameObject panzer, explosionBurstOuter;
	
	// Use this for initialization
	void Start () {
		angleLimit = 20;
		
	}
	
	// Update is called once per frame
	void Update () {
		startValue -= Time.deltaTime;
		if (Input.GetMouseButton(1)) 
		{
			
			if (startValue < 0) 
			{
				if (panzer.transform.rotation.eulerAngles.z < 90 && panzer.transform.rotation.eulerAngles.z > -90) {angleLimitMod = panzer.transform.rotation.eulerAngles.z;}
				
				Vector3 mousePos = Input.mousePosition;
				mousePos.z = -0.5f;
				
				Vector3 objectPos = mainCamera.camera.WorldToScreenPoint (transform.position);
				mousePos.x = mousePos.x - objectPos.x;
				mousePos.y = mousePos.y - objectPos.y;
				
				float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
				if (angle > angleLimit + angleLimitMod) {angle = angleLimit + angleLimitMod; }
				if (angle < angleLimitMod) {angle = angleLimitMod;}

				angle += Random.Range (-5, 5);

				GameObject newBullet;
				newBullet = Instantiate(bullet, this.transform.position, Quaternion.Euler(new Vector3(0, 0, angle))) as GameObject;

				GameObject boomOne;
				boomOne = Instantiate (explosionBurstOuter, this.transform.position, Quaternion.Euler(new Vector3(-angle, 90, 0))) as GameObject;
				boomOne.transform.parent = transform;

				TankMovement Script1 = panzer.GetComponent<TankMovement>();
				
				startValue = 0.05f;
			}
		}
		
	}
}
