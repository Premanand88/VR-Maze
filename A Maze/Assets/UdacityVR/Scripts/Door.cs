using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
    public static bool locked = true;
    bool opening = false;
    Animation openTheDoor = new Animation();
    public Transform goIN;

    private void Start()
    {
        openTheDoor = GetComponent<Animation>();
        GetComponent<Animation>().Stop();
    }

    void Update() {

        // If the door is opening and it is not fully raised
        // Animate the door raising up
        if (opening)
        {

            //if (GetComponent<Animation>().isPlaying)
            //{
            if (Camera.main.transform.parent.transform.position != goIN.transform.position)
            {
                Camera.main.transform.parent.transform.position = goIN.transform.position;
                opening = false;
            }
            //};
            //GetComponent<AudioSource>().Play();

        }
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
        // Set the "opening" boolean to true
        // (optionally) Else
        // Play a sound to indicate the door is locked
        GetComponent<AudioSource>().Play();
        opening = true;
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        locked = false;
    }
}
