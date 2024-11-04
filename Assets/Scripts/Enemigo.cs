using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour
{
    private NavMeshAgent agent;
    //private Personaje player;
    //El enemigo tiene que perseguir al Player.

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
       //player = GameObject.FindObjectOfType<Personaje>();
       anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //agent.SetDestination(player.gameObject.transform.position);
        if (agent.remainingDistance <= agent.stoppingDistance) 
        {
        
        }
    }
}
