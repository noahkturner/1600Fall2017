using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float speed = 12; //floats are numbers
	public float gravity = 9.81f;
	public CharacterController playerMove;
	public Vector3 movement;
	public float jumpHeight = 20;
	public static bool gameState = false; //a bool is a true or false operator
	public GameObject gameStateUI;
	
	
	void Update () { //the player must be grounded and the gameState must be false in order for the character to move
		movement.y -= gravity * Time.deltaTime; //a . operator is a way to access different members or methods. Time.deltaTime smooths out the time between frames (real time)
		if (playerMove.isGrounded && !gameState) //&& means both must be true. ! only gives true when the operand is false
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				movement.y = jumpHeight * Time.deltaTime;
			}
			movement.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		}
		playerMove.Move(movement); 
		
		if (transform.position.y <= -1) { //if the player falls below -1 in terms of its y position, then the game ends
			gameState = true;
			gameStateUI.SetActive(true);
		}   
	}

	
}
