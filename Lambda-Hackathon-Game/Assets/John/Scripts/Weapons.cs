using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Weapon", menuName = "Inventory/Weapons")]
public class Weapons : Pickup {

	public WeaponSlot weaponSlot;

	public int slotNumber;
	public int clipSize;
	public int currentAmmo;
	public int damage;
	public int reloadSpeed;
	public int handlingModifier;
	public int rateOfFire;

}

public enum WeaponSlot {LaserPistol, FlameThrower, AssaultRifle, Shotgun, RocketLauncher}
