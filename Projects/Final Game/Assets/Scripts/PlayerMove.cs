using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float speed = 12;
	public float gravity = 9.81f;
	public CharacterController playerMove;
	public Vector3 movement;
	public float jumpHeight = 20;
	public static bool gameState = false;
	public GameObject gameStateUI;
	
	
	void Update () {
		movement.y -= gravity * Time.deltaTime;
		if (playerMove.isGrounded && !gameState)
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				movement.y = jumpHeight * Time.deltaTime;
			}
			movement.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		}
		playerMove.Move(movement); 
		
		if (transform.position.y <= -1) {
			gameState = true;
			gameStateUI.SetActive(true);
		}   
	}

	
}
