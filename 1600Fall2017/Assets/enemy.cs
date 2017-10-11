using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour {

	public NavMeshAgent agent;
	public Transform player;
	
	// Update is called once per frame
	void Update () {
		agent.destination = player.position;
	}

	public void Stun (float _speed) {
		agent.speed = _speed;
	}
}
