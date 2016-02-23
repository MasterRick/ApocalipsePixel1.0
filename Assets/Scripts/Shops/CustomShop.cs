using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CustomShop : MonoBehaviour {
    public Text TextCoins;
	void Update () {
        if (PlayerPrefs.HasKey("Coins"))
        {
            TextCoins.text = "Coins " + PlayerPrefs.GetInt("Coins").ToString();
        }
        else
        {
            TextCoins.text = "Nada ainda";
        }
        if (Input.GetKey(KeyCode.Space))
        {
            PlayerPrefs.DeleteAll();
        }
    }
	public void Buy(int HowMuch)
	{
		if (HowMuch <= PlayerPrefs.GetInt("Coins")) {
			PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt ("Coins") - HowMuch);
			print ("comprou!");
		} else {
			print("I no have money!");
		}
	}
}
