using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnZombies : MonoBehaviour {

    [SerializeField]
    private GameObject[] zombies;
    public static int zombieCount;

    private int RandomNumber;

    void Start()
    {
        StartCoroutine(Spawn());
    }


    private IEnumerator Spawn()
    {
        if(zombieCount < 200)
        {
            Debug.Log(zombieCount);
            RandomNumber = Random.Range(0, zombies.Length);
            yield return new WaitForSeconds(2);
            Instantiate(zombies[RandomNumber], new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            StartCoroutine(Spawn());
        }
    }
}

    
