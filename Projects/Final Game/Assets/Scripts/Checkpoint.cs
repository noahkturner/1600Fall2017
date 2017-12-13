using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

	public ParticleSystem.TriggerModule particle;

	//OnTriggerEnter is a function that executes when the object (collider) hits the trigger
	void OnTriggerEnter() {
		PlayGame.startPosition = transform.position;
		//transforms the starting position of the PlayGame script, and therfore, the player to the location of the checkpoint
	}
}
