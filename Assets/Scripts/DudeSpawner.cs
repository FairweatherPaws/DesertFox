using UnityEngine;
using System.Collections;

public class DudeSpawner : MonoBehaviour {

	public float spawnTimer = 2f;
	public GameObject enemyDude;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		spawnTimer -= Time.deltaTime;
		if (spawnTimer < 0) {
			spawnTimer = 2f;
			GameObject newDude;
			newDude = Instantiate (enemyDude, this.transform.position, Quaternion.identity) as GameObject;
		}
	
	}
}
