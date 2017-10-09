using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathFunctions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		myScore = ReturnNum (health, ammo);
		myPassword =  ReturnPassword(myPassword);
	}
	
	public int myScore = 100;

	public int health;
	public int ammo;
	
	public string myPassword = "CoolStuff";

	int ReturnNum (int _num, int _num2) {
		return _num + _num2;
	}

	string ReturnPassword (string _login) {

		if(_login == "ou812") {
			 return "Password Correct";
		} else {
			return "Incorrect";
		}
	}
}