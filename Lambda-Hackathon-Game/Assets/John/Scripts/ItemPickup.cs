using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

	public Pickup pickup;
	public AudioClip collectSound;
	AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 30, 0) * Time.deltaTime * 1.5f);
	}

	
	void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Player"))
        {
			PickupItem();
			Destroy(gameObject, collectSound.length);
        }
    }

	void PickupItem ()
	{
		// if gun exists, add 1 clip of ammo
		audioSource.PlayOneShot(collectSound);
		Inventory.instance.Add(pickup);
	}
}
