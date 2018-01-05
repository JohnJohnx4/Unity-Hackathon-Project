using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultRifleFX : MonoBehaviour {
 	
	[SerializeField]
    private GameObject gunflash, gunTrigger;
	
	void Update () {
        if (Input.GetMouseButton(0))
        {
            gunflash.SetActive(true);
            gunTrigger.SetActive(true);
        }
        else
        {
            gunflash.SetActive(false);
            gunTrigger.SetActive(false);
        }
	}

}
