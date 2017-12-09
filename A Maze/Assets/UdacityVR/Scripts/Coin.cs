using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public ParticleSystem coinPicked;
    public GameObject coinSelected;

    public float speed = 30.0F;
    //private bool reverse = false;
    Transform check ;

    private void Update()
    {
        coinSelected.transform.Rotate(0f, Time.deltaTime* speed, 0f);
    }
    public void OnCoinClicked() {

        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy

        CoinCollected updateCoinCount = new CoinCollected();
        updateCoinCount.UpdateCount();
        var playAudio = coinPicked.GetComponent<AudioSource>();
        playAudio.Play();
        coinPicked.Play();
        Destroy(coinSelected);
    }

}
