using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public static Inventory instance;
	void Awake ()
	{
		if (instance != null)
		{
			Debug.LogWarning("More than one instance of Inventory found");
			return;
		}
		instance = this;
	}

	public List<Pickup> pickups = new List<Pickup>();

	public void Add (Pickup pickup)
	{
		pickups.Add(pickup);
	}
}
