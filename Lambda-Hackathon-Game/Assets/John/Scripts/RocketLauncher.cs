using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour {

	public GameObject rocket;
	public Transform rocketSpawn;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			
			Instantiate(rocket, rocketSpawn.position, rocketSpawn.rotation);

		}
	}
}
