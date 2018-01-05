using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeDamage : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Regular Zombie")
        {
            Debug.Log("Collide");
            PlayerStats.Health -= 10;
            if(PlayerStats.Health < 1)
            {
                PlayerStats.Health = 100;
                spawnZombies.zombieCount = 0;
                SceneManager.LoadScene("World");
            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Regular Zombie")
        {
            Debug.Log("Nothing here probably");
        }
    }



}
