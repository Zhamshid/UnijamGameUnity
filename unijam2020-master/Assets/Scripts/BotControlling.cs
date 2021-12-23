using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BotControlling : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    NavMeshAgent agent;
    public float enemyDist = 3.0f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //float distance = Vector3.Distance(transform.position, player.transform.position);

        //if (distance < enemyDist) {
        //    Vector3 dirToPlay =player.position;
        //    Vector3 newPos = dirToPlay;
        //    agent.Warp(newPos);
      //  }
        // Vector3 dirToPlay = transform.position - player.position;
        //Vector3 newPos = transform.position + dirToPlay;
        //agent.Warp(newPos);       
        agent.SetDestination(player.position);
    }
}
