using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CameraAI : MonoBehaviour {

	public Transform cameraPos;
	public NavMeshAgent trackPlayer;

	void Update () {
		trackPlayer.destination = cameraPos.position;
	}
}
