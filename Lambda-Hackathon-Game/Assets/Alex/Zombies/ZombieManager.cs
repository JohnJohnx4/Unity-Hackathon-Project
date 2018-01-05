using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieManager : MonoBehaviour {

    [SerializeField]
    private GameObject fire, blood;
    public static int zombiesKilled;
    private int zombieHealth = 100;

    void Start()
    {
        spawnZombies.zombieCount += 1;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Flame Collider")
        {
            fire.SetActive(true);
            StartCoroutine(FireLength());
        }
        if (other.name == "Gun Collider")
        {
            fire.SetActive(true);
            StartCoroutine(FireLength());
        }
    }


    private IEnumerator FireLength()
    {
        zombieHealth -= 25;
       // Debug.Log(zombieHealth);
        if(zombieHealth < 1)
        {
            Instantiate(blood, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            spawnZombies.zombieCount -= 1;
            zombiesKilled += 1;
            Destroy(this.gameObject, 1);
        }
        yield return new WaitForSeconds(3);
        StartCoroutine(FireLength());
    }


}
