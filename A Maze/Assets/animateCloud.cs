using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animateCloud : MonoBehaviour {
    

    CoinCollected updateCoinCount = new CoinCollected();
    bool win = false;
    public Text coinsText;
    public static bool Run;
    // Use this for initialization
    void Start () {
        Run = false;
    }

    // Update is called once per frame
    void Update () {
		if(coinsText.text == "6" && !win)
        {           
            win = true;
            PlayAnimation();
        }

       
    }
    void PlayAnimation()
    {
        if (win) { 
            GetComponent<Animation>().Play();
            Run = true;
        }
    }

    public bool IsRun()
    {
        return Run;
    }
}
