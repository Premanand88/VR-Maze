using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinClick : MonoBehaviour {


    public ParticleSystem coinPicked;
    public GameObject coinSelected;
    // Use this for initialization

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EnableParticle()
    {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
        //updateCoinCount.GetComponent<CoinCollected>().CoinCount += 1;
        //////GetComponent.<CoinCollected>() = someNumber; 
        //+= 1;
        //coinPicked.Simulate(0.2f, false, true);
        coinPicked.Play();
        Destroy(coinSelected);
    }
}
