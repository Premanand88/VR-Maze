using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour {

    public Text coinsText;
    CoinCollected updateCoinCount = new CoinCollected();
   
    bool win = false;
    // Use this for initialization
    void Start () {
		//coinsText = GameObject.FindGameObjectWithTag("Score");
    } 
	
	// Update is called once per frame
	void Update () {
        coinsText.text = updateCoinCount.getScore().ToString();  
    }   
}
