using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonsMainMenu : MonoBehaviour {

	void Update()
	{
		if (ControlGame.getControle() != null) {
			PlayerPrefs.SetInt("Coins", ControlGame.getControle().SavedCoins + ControlGame.getControle().SavedCoins2);
		}
	}
	public void ChageScene(string Scene)
	{
		PlayerPrefs.Save();
        SceneManager.LoadScene(Scene);
    }
	public void Exit()
	{
		Application.Quit ();
	}
}
