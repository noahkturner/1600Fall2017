using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveCheckPoint : MonoBehaviour {

	public Transform player;
	Vector3 checkPoint;
	string[] playerPrefsTitles = {"CheckPointX", "CheckPointY", "CheckPointZ"}; 
	
	void OnTriggerEnter () {
		checkPoint = transform.position;
		for (int i = 0; i < playerPrefsTitles.Length; i++)
		{
			PlayerPrefs.SetFloat(playerPrefsTitles[i], checkPoint[i]);
		}
	}

	void Start()
	{
		for (int i = 0; i < playerPrefsTitles.Length; i++)
		{
			checkPoint[i] = PlayerPrefs.GetFloat(playerPrefsTitles[i]);
		}
		player.position = checkPoint;
	}
}
