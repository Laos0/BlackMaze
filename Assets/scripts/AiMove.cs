using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiMove : MonoBehaviour {

    public NavMeshAgent agent;
    public Transform[] moveSpot;
    public int randomMoveSpot;
 

	// Use this for initialization
	void Start () {
        if(agent == null){

            Debug.Log("Agent is null.");
        }else{
            //setDestination();
        }

        randomMoveSpot = Random.Range(0, moveSpot.Length);


	}
	
	// Update is called once per frame
	void FixedUpdate () {

        agent.SetDestination(moveSpot[randomMoveSpot].position);

        if(transform.position == moveSpot[randomMoveSpot].position){
            Debug.Log("I am here");
        }
	}

    void setDestination(){

       // agent.SetDestination(moveSpot.position);
    }
}
