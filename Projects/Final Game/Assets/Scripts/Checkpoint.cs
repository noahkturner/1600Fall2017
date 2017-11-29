using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

	void OnTriggerEnter() {
		PlayGame.startPosition = transform.position;
	}
}
