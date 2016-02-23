using UnityEngine;
using System.Collections;

public class II : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        ControlGame.getControle().SavedCoins += 1;
    }
}
