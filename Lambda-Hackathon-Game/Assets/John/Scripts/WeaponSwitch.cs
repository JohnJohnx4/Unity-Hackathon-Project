using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour {

	public GameObject assaultRifle, laserPistol, rocketLauncher, flamethrower, shotgun;
	// Use this for initialization
	void Start () {
		assaultRifle = GameObject.Find("Player Assault Rifle");
		laserPistol = GameObject.Find("Player Laser Pistol");
		rocketLauncher = GameObject.Find("Player Rocket Launcher");
		flamethrower = GameObject.Find("Player Flamethrower");
		shotgun = GameObject.Find("Player Shotgun");

		assaultRifle.SetActive(false);
		laserPistol.SetActive(false);
		rocketLauncher.SetActive(false);
		flamethrower.SetActive(false);
		shotgun.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		Switch();
	}

	void Switch () {

		if (Input.GetButtonDown("1") && InventoryChecker("Assault Rifle")) {
			SetActiveWeapon(1);
		}
		if (Input.GetButtonDown("2") && InventoryChecker("Laser Pistol")) {
			SetActiveWeapon(2);
		}
		if (Input.GetButtonDown("3") && InventoryChecker("Rocket Launcher")) {
			SetActiveWeapon(3);
		}
		if (Input.GetButtonDown("4") && InventoryChecker("Flamethrower")) {
			SetActiveWeapon(4);
		}
		if (Input.GetButtonDown("5") && InventoryChecker("Shotgun")) {
			SetActiveWeapon(5);
		}
	}

	bool InventoryChecker (string weapon) {
		bool invChecker = false;
		for (int i = 0; i < Inventory.instance.pickups.Count; i++) {
			if (Inventory.instance.pickups[i].name == weapon) {
				invChecker = true;
			}
		}
		print(invChecker);
		return invChecker;
	}

	void SetActiveWeapon (int weapon) {
		if (weapon == 1) {
			assaultRifle.SetActive(true);
			laserPistol.SetActive(false);
			rocketLauncher.SetActive(false);
			flamethrower.SetActive(false);
			shotgun.SetActive(false);
		}
		if (weapon == 2) {
			laserPistol.SetActive(true);
			assaultRifle.SetActive(false);
			rocketLauncher.SetActive(false);
			flamethrower.SetActive(false);
			shotgun.SetActive(false);
		}
		if (weapon == 3) {
			rocketLauncher.SetActive(true);
			assaultRifle.SetActive(false);
			laserPistol.SetActive(false);
			flamethrower.SetActive(false);
			shotgun.SetActive(false);
		}
		if (weapon == 4) {
			flamethrower.SetActive(true);
			assaultRifle.SetActive(false);
			laserPistol.SetActive(false);
			rocketLauncher.SetActive(false);
			shotgun.SetActive(false);
		}
		if (weapon == 5) {
			shotgun.SetActive(true);
			assaultRifle.SetActive(false);
			laserPistol.SetActive(false);
			rocketLauncher.SetActive(false);
			flamethrower.SetActive(false);
		}

	}


	//========END OF FILE
}
