using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

public string[] foxFood = {"Bananas", "Apples", "Grapes", "Chicken", "Turkey", "Cake"};
public int[] foodCount = {10, 2, 30, 1, 2, 1};

	// Use this for initialization
	public virtual void Start () {
		
		for (int i = 0; i < foxFood.Length; i++)
		{
			Eat(foxFood[i], foodCount[i]);
		}
		
		Sleep();
	}

	void Die () {
			print(this.name + " Dies");
	}
	
	void Eat (string food, int amount) {
			print(this.name + " likes to eat " + food);
			print(this.name + " ate " + amount);
	}

	void Sleep () {
			print(this.name + " Sleeps");
	}
}
