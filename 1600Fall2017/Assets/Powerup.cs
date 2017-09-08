using UnityEngine;

public class Powerup : MonoBehaviour {
	void OnTriggerEnter()
	{
		gameObject.SetActive(false);
	}
}
