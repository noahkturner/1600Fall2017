﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour {

	public static Vector3 start;
	public GameObject gameStart;
	public Transform player;
	public Image lifeBar;
	private float fillBar;

	
	void Awake () {
		gameStart.SetActive(false);
		start = player.position;
		fillBar = lifeBar.fillAmount;
	}
	
	
	public void Click () {
		PlayerMove.gameState = false;
		gameStart.SetActive(false);
		lifeBar.fillAmount = fillBar;
		//player.position = startPosition;
	}
}
