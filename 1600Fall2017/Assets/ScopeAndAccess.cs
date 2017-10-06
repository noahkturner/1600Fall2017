using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccess : MonoBehaviour {

	string thing1 = "Thing1";
	string thing2;
	
	public void Box () {
		thing1 = "Fun";
		thing2 = "Things it can't do. What it can't do, is go out of the box. It's Sad oh so sad, like the Fox with the Socks.";
		print(thing2);
	}

	void NewBox () {
		thing1 = "New Thing.";
		thing2 = "New Thing Too.";
	}
}
