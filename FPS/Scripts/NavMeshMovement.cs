using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{


    Transform player;               // Reference to the player's position.
    PlayerHealth playerHealth;      // Reference to the player's health.
    NavMeshAgent nav;               // Reference to the nav mesh agent.


    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        nav = GetComponent<NavMeshAgent>();

        nav.updateRotation = true;
    }


    void Update()
    {
        // If the enemy and the player have health left...
        if (playerHealth.Health.value > 0)
        {
            // ... set the destination of the nav mesh agent to the player.





            nav.SetDestination(player.position);


            nav.updateRotation = true;
            nav.enabled = true;


        }

        // Otherwise...
        else
        {
            // ... disable the nav mesh agent.
            nav.enabled = false;

        }
    }


}
