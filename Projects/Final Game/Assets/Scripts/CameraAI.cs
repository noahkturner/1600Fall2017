using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CameraAI : MonoBehaviour {

	public Transform cameraPos; //keeps track of objects scale, position, and rotation
	public NavMeshAgent trackPlayer; //allows an object to move about on a nav mesh

	//Update is a function that is called every frame 
	void Update () {
		trackPlayer.destination = cameraPos.position; //this updates the position of the camera, and the enemies, to follow the destination of the player
	}
}
