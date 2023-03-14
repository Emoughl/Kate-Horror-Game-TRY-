using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundTextDoor : MonoBehaviour
{
    public float theDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TheDoor;
    public AudioSource Sound;
    // Update is called once per frame
    void Update()
    {
        theDistance = OpenDoor.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if(theDistance<=3)
        {
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        if(Input.GetButtonDown("DoorOpen"))
        {
            if(theDistance<=3)
            {
            this.GetComponent<BoxCollider>().enabled = false;
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            TheDoor.GetComponent<Animation>().Play("OpenDoor01");
            Sound.Play();
            }
        }
    }
    private void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
