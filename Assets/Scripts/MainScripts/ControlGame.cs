using UnityEngine;
using System.Collections;

public class ControlGame : MonoBehaviour {
    //Variable to local script
    private static ControlGame CG;
    [HideInInspector]
    public int SavedCoins = 0;
    public int SavedCoins2 = 0;
    //Get variables this script without GetComponent
     void Awake()
    {
        SavedCoins2 = PlayerPrefs.GetInt("Coins");
    }
    public static ControlGame getControle()
    {
        if (CG == null)
        {
            CG = GameObject.FindObjectOfType<ControlGame>();
        }
        return CG;
    }
    void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Coins", SavedCoins + SavedCoins2);
        PlayerPrefs.Save();
    }
}
