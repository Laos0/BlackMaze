using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiMove : MonoBehaviour {

    public NavMeshAgent agent;
    public Transform player;
    public Transform[] moveSpot;
    public Transform destination;
    public Transform destination1;
    public int randomMoveSpot;
    public int counter;
 

	// Use this for initialization
	void Start () {
        counter = 0;
        if(agent == null){

            Debug.Log("Agent is null.");
        }else{
            setDestination();

        }

        randomMoveSpot = Random.Range(0, moveSpot.Length);


	}
	
	// Update is called once per frame
	void FixedUpdate () {

        // isAtDestination();
        followPlayerByPathFinding();

    }

    void setDestination(){

        if (counter <= 0)
        {
            agent.SetDestination(destination.position);
            counter++;
        }
        else
        {
            agent.SetDestination(destination1.position);
        }
    }

    void followPlayerByPathFinding()
    {
        agent.destination = player.transform.position;

    }

    bool isAtDestination()
    {

        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    Debug.Log("Hit destination");
                    setDestination();
                    return true;
                }
        
            }
        }

        return false;
        
    }
}
