using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralControl : MonoBehaviour {

	public Image barUI;
	public Text gameOverText;
	public Text collectNum;
	public int totalCollectValue;
	public int collectValue = 1;
	public GameObject gameStateUI;
	public float strengthPwr = 0.1f;
	public float addAmount = 0.01f;

	public enum PowerUpCat
	{
		PowerUp,
		PowerDown,
		Collection,
		Win
	}

	public PowerUpCat powerUp;

	void OnTriggerEnter() {
		switch (powerUp)
		{
			case PowerUpCat.PowerUp:
				StartCoroutine(PowerUpBar());
			break;

			case PowerUpCat.PowerDown:
				StartCoroutine(PowerDownBar());
			break;

			case PowerUpCat.Collection:
				StartCoroutine(Collection());
			break;

			case PowerUpCat.Win:
				EndGame("Winner!");
			break;
		}
	}

	IEnumerator Collection () {
		totalCollectValue = int.Parse(collectNum.text);
		int tempAmount = totalCollectValue + collectValue;
		while (totalCollectValue <= tempAmount)
		{
			collectNum.text = (totalCollectValue++).ToString();
			yield return new WaitForFixedUpdate();
		}
	}

	IEnumerator PowerUpBar () {
		float tempAmount = barUI.fillAmount + strengthPwr;
		if (tempAmount > 1)
		{
			tempAmount = 1;
		}
		while (barUI.fillAmount < tempAmount)
		{
			barUI.fillAmount += addAmount;
			yield return new WaitForSeconds(addAmount);
		}
	}

	IEnumerator PowerDownBar () {
		float tempAmount = barUI.fillAmount - strengthPwr;
		if (tempAmount < 0)
		{
			tempAmount = 0;
		}
		while (barUI.fillAmount > tempAmount)
		{
			barUI.fillAmount -= addAmount;
			yield return new WaitForSeconds(addAmount);
		}
	}

	void EndGame (string _text) {
		gameOverText.text = _text;
		gameStateUI.SetActive(true);
		PlayerMove.gameState = true;
	}
	
}
