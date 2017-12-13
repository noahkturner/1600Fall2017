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
	public GameObject collectGone;
	public string minimum = "70";


	public enum PowerUpCat //starts a list of enumerators that are easily accessed, each with their own parameters
	{
		PowerUp,
		PowerDown,
		Collection,
		Win,		
	}

	public PowerUpCat powerUp;

	void OnTriggerEnter() { //allows for multiple values to be tested. each value is a case with variables inside. the end of each case must include a break
		switch (powerUp)  
		{
			case PowerUpCat.PowerUp: //starts a function that holds off on executing until the yield specifications are fulfilled
				StartCoroutine(PowerUpBar());
			break;

			case PowerUpCat.PowerDown:
				StartCoroutine(PowerDownBar());
			break;

			case PowerUpCat.Collection:
				StartCoroutine(Collection());
			break;

			case PowerUpCat.Win:
				if (collectNum.text == minimum) //this means that the collectNum text and the minimum text must be the same when you reach the end, otherwise you won't win
				{
					EndGame("You Win!");
				}
				else 
				{
					EndGame("You need at least 70 points to win! Try Again!");
					PlayerMove.gameState = true;
				}
			break;
			
		}
	}

	IEnumerator Collection () { //IEnumerator methods must return something. parse converts the collectnum text into an int
		totalCollectValue = int.Parse(collectNum.text);
		int tempAmount = totalCollectValue + collectValue; //this adds the new amount to the previous amount
		while (totalCollectValue <= tempAmount) //while the tcv is less than the ta, the tcv goes up by 1 and is converted into a string that is assinged to collectnum
		{
			collectNum.text = (totalCollectValue++).ToString();
			yield return new WaitForFixedUpdate();
		}

		
		collectGone.SetActive(false); //this hides/destroys the object after the player collides with it
	}

	IEnumerator PowerUpBar () { //this dictates how much life the powerups add to the lifebar, and places a ceiling at 1
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

		if (barUI.fillAmount == 0){
			EndGame("Game Over");
		}
	
	}

	void EndGame (string _text) { //there is an argument within the parameters. when the endgame panel is triggered, it displays the appropriate text, freezes the player, and shows the button
		gameOverText.text = _text;
		gameStateUI.SetActive(true);
		PlayerMove.gameState = true;
	}

	
	
}
