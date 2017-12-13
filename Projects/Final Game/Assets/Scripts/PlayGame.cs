using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour {

	public static Vector3 startPosition;
	public GameObject gameStart;
	public Transform player;
	public Image lifeBar;
	private float fillBar;


	
	void Awake () { //awake is called before anything else (used to set stuff up). this sets up the start position, fill amount of the bar, and the game state
		gameStart.SetActive(false);
		startPosition = player.position;
		fillBar = lifeBar.fillAmount;
	}
	
	
	public void Click () {
		PlayerMove.gameState = false;
		gameStart.SetActive(false);
		lifeBar.fillAmount = fillBar;
		player.position = startPosition;
	}

	
}
