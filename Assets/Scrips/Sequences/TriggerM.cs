using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerM : MonoBehaviour
{
    public AudioSource doorBang;
    public AudioSource zombieSound;
    public GameObject theZombie;
    public GameObject theDoor;
    public GameObject tourch;

    private void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        theDoor.GetComponent<Animation>().Play("OpenDoor02");
        doorBang.Play();
        zombieSound.Play();
        StartCoroutine(Tstart());
    }
    IEnumerator Tstart()
    {
        yield return new WaitForSeconds(1f);
        tourch.SetActive(false);
        theZombie.SetActive(false);
        yield return new WaitForSeconds(5f);
        tourch.SetActive(true);
    }
}
