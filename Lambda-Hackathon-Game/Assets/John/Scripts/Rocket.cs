using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

	private Rigidbody rb;
	public float thrust = 300.0f;
	public GameObject explosion;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, 5);
		rb = GetComponent<Rigidbody>();
	}

	void Update() {
		rb.AddRelativeForce(Vector3.forward * 5.0f, ForceMode.VelocityChange);
	}

	void OnCollisionEnter(Collision collision) {
		
		Instantiate(explosion, transform.position, transform.rotation);
		Destroy(gameObject);
	}

}
