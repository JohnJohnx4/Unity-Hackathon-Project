using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

    public static int Health = 100;
    public static int AssaultRifle = 100;
    public static int RocketLauncher = 10;
    public Slider mainSlider;
    public Text Ammo;
    public Text ZombiesKilled;
    public Text ZombiesAlive;

    public static int currectWeapon = 1;

    void Start()
    {
        //        playerHealth = GameObject.Find("HealthSlider").GetComponent<Image>();
        
    }

    void Update()
    {
        mainSlider.value = Health;
        ZombiesKilled.text = "Zombies Killed: " + ZombieManager.zombiesKilled.ToString();
        ZombiesAlive.text = "Zombies Alive: " + spawnZombies.zombieCount.ToString();
        if (currectWeapon == 1)
        {
            Ammo.text = AssaultRifle.ToString() +  "/ 100";
        }
        
    }
}




