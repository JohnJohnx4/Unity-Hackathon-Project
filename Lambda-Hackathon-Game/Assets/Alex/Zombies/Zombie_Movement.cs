using UnityEngine;
using System.Collections;

public class Zombie_Movement : MonoBehaviour
{
    Transform player;
    UnityEngine.AI.NavMeshAgent nav;

    private bool chase, turnAround;

    void Awake()
    {
        chase = true;//dev only
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.name == "player trigger")
    //    {
    //        chase = false;
    //    }
    //    //debug.log("exit");
    //}

    //void OnTriggerEnter(Collider other)
    //{
    //    //debug.log("enter");
    //    if (other.name == "player trigger")
    //    {
    //        chase = true;
    //    }
    //}

    void Update()
    {
        if (chase)
        {
            //Debug.Log("Here");
            //nav.enabled = true;
            turnAround = true;
            //GetComponent<Animator>().enabled = true;
            nav.SetDestination(player.position);
        }
        else
        {
            nav.enabled = false;
            //GetComponent<Animator>().enabled = false;
            if (turnAround)
            {
                StartCoroutine(TurnAroundNoMore());
                transform.Rotate(0, Time.deltaTime * 30, 0, Space.Self);
            }
        }
    }
    private IEnumerator TurnAroundNoMore()
    {
        yield return new WaitForSeconds(6);
        turnAround = false;
    }
}


