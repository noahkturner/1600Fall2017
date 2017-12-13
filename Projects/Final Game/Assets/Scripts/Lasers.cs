using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasers : MonoBehaviour {

	public Transform beginning;
	public Transform terminate;
	public LineRenderer laser;
	void Update () {
		laser.SetPosition(0, beginning.position);
		laser.SetPosition(1, terminate.position);
	}

}
