using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifStatement : MonoBehaviour {

	public Text input;

	public bool canPlayGame = false;
	public string password = "G@am3Pl@y";

	void Update () {
		if(input.text == password) {
<<<<<<< HEAD
			print("You know the password");
=======
			print("You know the password.");
>>>>>>> master
			canPlayGame = true;
		} else {
			print("The password is incorrect.");
		}

		if(canPlayGame) {
			print("Playing Game");
<<<<<<< HEAD
		}   else {
			print("Can't Play Yet, Enter a correct password.");
=======
		}	else {
			print("Can't Play Yet, Enter a Correct Password.");
>>>>>>> master
		}
	}
}
