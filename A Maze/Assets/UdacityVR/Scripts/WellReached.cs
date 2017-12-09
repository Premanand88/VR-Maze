using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellReached : MonoBehaviour {

    public Transform playerPosition;
    public Transform wayPointPos;
    public int CoinsUsed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnDropCoin()
    {
        if(playerPosition.position == wayPointPos.position)
        {
            CoinCollected updateCoinCount = new CoinCollected();
            updateCoinCount.CoinDropped();
        }
    }

}
