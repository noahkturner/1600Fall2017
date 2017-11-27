using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : MonoBehaviour {

	public static Vector3 start;
	public GameObject gameStart;
	public Transform player;

	
	void Awake () {
		gameStart.SetActive(false);
		start = player.position;
	}
	
	
	public void Click () {
		PlayerMove.gameState = false;
		gameStart.SetActive(false);
	}
}
