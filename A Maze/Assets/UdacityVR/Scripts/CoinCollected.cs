using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollected : MonoBehaviour {

    public int showCoin;
    private static int CoinCount;
    public static int CoinDrop;

    public static CoinCollected Instance;
    // Use this for initialization
    void Start () {
        CoinCount = 0;
        CoinDrop = 0;
    }
	
	// Update is called once per frame
	void Update () {
        showCoin = CoinDrop;
    }

    public void UpdateCount()
    {
        CoinCount += 1; 
    }

    public void CoinDropped()
    {
        CoinDrop = (CoinCount- CoinDrop) + CoinDrop;
    }

    public int getScore()
    {
        return CoinDrop;
    }
}
